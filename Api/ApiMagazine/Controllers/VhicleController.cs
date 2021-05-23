using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Repository;
using Newtonsoft.Json;
using Domain.Helpers;
using Domain.Models;
using ApiDomain.Models;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VhicleDataController : ControllerBase
    {
        private IVehicleDatumRepository repository;

        public VhicleDataController(IVehicleDatumRepository rep)
        {
            repository = rep;
        }
        

        /// <summary>
        /// /VhicleData/AddData
        /// Добавление нового продукта
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public string AddData(VehicleDatum model)
        {
            string result = "";
            try
            {
                VehicleDatumHelper.Add(model);
            }          
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// /VhicleData/GetAllVhicleDataForDate
        /// Получить все данные 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public string GetAllVhicleDataForDate(GetDataForDateModel model)
        {
            try
            {
                var result = repository.GetAllVhicleDataWithDate(model.FirstDate, model.SecondDate);
                return JsonConvert.SerializeObject(result);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// /VhicleData/GetDataForSensor
        /// Получить данные связанные с сенсором
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public string GetDataForSensor(GetDataForSensor model)
        {
            try
            {
                var result = repository.GetAllVhicleDataForSensor(model.key, model.firstDate, model.secondDate);
                return JsonConvert.SerializeObject(result);
            }
            catch
            {
                return null;
            }
        }

        [HttpGet]
        public string GetAllData()
        {
            try
            {
                var result = repository.GetAllVhicleData();
                return JsonConvert.SerializeObject(result);
            }
            catch
            {
                return null;
            }
        }
    }
}
