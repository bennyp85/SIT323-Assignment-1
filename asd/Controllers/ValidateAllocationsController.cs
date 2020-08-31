using System;
using asd.Interface;
using Microsoft.AspNetCore.Mvc;

namespace asd.Controllers
{
    public class ValidateAllocationsController : Controller
    {
        private readonly IValidateAllocations _validateAllocations;
        public ValidateAllocationsController(IValidateAllocations validateAllocations)
        {
            _validateAllocations = validateAllocations;
        }
    }
}
