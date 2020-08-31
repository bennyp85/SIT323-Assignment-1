using System;
using asd.Interface;
using Microsoft.AspNetCore.Mvc;

namespace asd.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly IConfiguration _configuration;
        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
