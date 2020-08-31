using System;
using asd.Interface;
using Microsoft.AspNetCore.Mvc;

namespace asd.Controllers
{
    public class ValidateCffController : Controller
    {
        private readonly IValidateCff _validateCff;
        public ValidateCffController(IValidateCff validateCff)
        {
            _validateCff = validateCff; 
        }
    }
}
