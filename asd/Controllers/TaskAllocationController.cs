using System;
using asd.Interface;
using Microsoft.AspNetCore.Mvc;

namespace asd.Controllers
{
    public class TaskAllocationController : Controller
    {
        private readonly ITaskAllocation _taskAllocation;
        public TaskAllocationController(ITaskAllocation taskAllocation)
        {
            _taskAllocation = taskAllocation;
        }
    }
}
