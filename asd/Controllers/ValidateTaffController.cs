using System;
using asd.Interface;
using Microsoft.AspNetCore.Mvc;

namespace asd.Controllers
{
    public class ValidateTaffController : Controller
    {
        private readonly IValidateTaff _validateTaff;
        public ValidateTaffController(IValidateTaff validateTaff)
        {
            _validateTaff = validateTaff;
        }
    }
}
