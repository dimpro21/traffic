using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Repository;
using Newtonsoft.Json;
using Domain.Models;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VhicleDataController : ControllerBase
    {
        private IRepository repository;

        public VhicleDataController(IRepository rep)
        {
            repository = rep;
        }

        /// <summary>
        /// /Product/AddProduct
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
                VehicleDatumHelper.AddProduct(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetAllData()
        {

        }
        /// <summary>
        /// /Product/DeleteProduct/?id={id}
        /// Удаление продукта
        /// </summary>
        /// <param name="id">Идентификатор продукта</param>
        /// <returns></returns>
        [HttpGet]
        public string DeleteProduct(int id)
        {
            string result = "";
            try
            {
                ProductHelper.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
