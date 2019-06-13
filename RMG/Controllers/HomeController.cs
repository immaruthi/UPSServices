﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RMG.Models;

namespace RMG.Controllers
{
    [Route("api/[Controller]")]
    public class HomeController : Controller
    {
        [HttpGet("[action]")]
        public int GetallEmployeeCount()
        {
            HomeContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.HomeContext)) as HomeContext;
            return context.GetallEmployeeCount();
        }

        [HttpGet("[action]")]
        public int GetallEmpProjCount()
        {
            HomeContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.HomeContext)) as HomeContext;
            return context.GetallEmpProjCount();
        }

        [HttpGet("[action]")]
        public int GetallEmpBenchCount()
        {
            HomeContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.HomeContext)) as HomeContext;
            return context.GetallEmpBenchCount();
        }

        [HttpGet("[action]")]
        public int GetallProjCount()
        {
            HomeContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.HomeContext)) as HomeContext;
            return context.GetallProjCount();
        }

        [HttpGet("[action]")]
        public int GetallCustomerCount()
        {
            HomeContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.HomeContext)) as HomeContext;
            return context.GetallCustomerCount();
        }
    }
}