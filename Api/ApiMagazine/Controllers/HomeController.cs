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
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// /Home/Index
        /// Добавление нового продукта
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public string Index()
        {
            string result = "Добро пожаловать на решение команды KS2Doors для кейса TRAFFIC HOOK!";
            return result;
        }
    }
}
