﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UPS.AddressTranslationService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UPS.AddressTranslationService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("[action]")]
        public bool ValidateUser(String userId, String password)
        {
            //LoginContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.LoginContext)) as LoginContext;
            return true; //context.ValidateUser(userId, password);
        }



        [HttpGet("[action]")]
        public bool ValidateUserId(String userId)
        {
            //LoginContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.LoginContext)) as LoginContext;
            return true;//context.ValidateUserId(userId);
        }
        [HttpGet("[action]")]
        public LoginData getLoginData(string Emp_Id)
        {
            //LoginDataContext context = HttpContext.RequestServices.GetService(typeof(RMG.Models.LoginDataContext)) as LoginDataContext;

            LoginData loginData = new LoginData()
            {
                Emp_Id = Emp_Id,
                Last_Login_Date = System.DateTime.Now.ToString()
            };

            return loginData;//context.getLoginData(Emp_Id);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
