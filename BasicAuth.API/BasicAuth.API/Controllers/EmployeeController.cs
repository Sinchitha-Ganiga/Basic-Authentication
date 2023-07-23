﻿using BasicAuth.API.BasicAuth;
using BasicAuth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicAuth.API.Controllers
{
    [RoutePrefix("api/Employees")]
    [BasicAuthenticationAttribute]
    public class EmployeeController : ApiController
    {
        //GetFewEmployees - NormalUser
        [Route("GetFewEmployees")]
        [BasicAuthorizationAttribute(Roles ="User")]
        public HttpResponseMessage GetFewEmployees()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Employee.GetEmployees().Where(e=> e.Id < 3));
        }

        //GetMoreEmployees - AdminUser
        [Route("GetMoreEmployees")]
        [BasicAuthorizationAttribute(Roles = "Admin")]
        public HttpResponseMessage GetMoreEmployees()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Employee.GetEmployees().Where(e => e.Id < 6));
        }

        //GetAllEmployees - SuperadminUser
        [Route("GetAllEmployees")]
        [BasicAuthorizationAttribute(Roles = "SuperAdmin")]
        public HttpResponseMessage GetAllEmployees()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Employee.GetEmployees());
        }
    }
}
