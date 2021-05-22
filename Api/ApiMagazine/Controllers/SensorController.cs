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
    public class SensorController : ControllerBase
    {
        private ISensorRepository repository;

        public SensorController(ISensorRepository rep)
        {
            repository = rep;
        }

        
    }
}
