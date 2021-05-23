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
    public class SensorController : ControllerBase
    {
        private ISensorRepository repository;

        public SensorController(ISensorRepository rep)
        {
            repository = rep;
        }

        /// <summary>
        /// /Sensor/AddSensor
        /// Добавить новый сенсор
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public string AddSensor(int key)
        {
            string result = "TRUE";
            try
            {
                SensorHelper.Add(key);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;

        }

        /// <summary>
        /// /Sensor/GetAllSensor
        /// Получить список всех сенсоров
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetAllSensor()
        {
            string result = "";
            try
            {
                result = JsonConvert.SerializeObject(repository.GetAllSensors());
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// /Sensor/GetSensorByKey
        /// Получить сенсор по ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet]
        public string GetSensorByKey(int key)
        {
            string result = "";
            try
            {
                result = JsonConvert.SerializeObject(repository.GetSensorById(key));
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
