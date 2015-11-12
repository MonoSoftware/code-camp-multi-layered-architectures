using AutoMapper;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebAPI
{
    public class UserController : ApiController
    {
        #region Constructors

        public UserController(IUserService service)
        {
            this.Service = service;
        }

        #endregion Constructors

        #region Properties

        public IUserService Service { get; set; }

        #endregion Properties

        #region Methods

        [HttpGet]
        [Route("users")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(Mapper.Map<List<User>>(Service.Get()));
        }

        #endregion Methods

        #region Classes

        public class User
        {
            #region Properties

            public string Description { get; set; }

            public string FirstName { get; set; }

            public Guid Id { get; set; }

            public string LastName { get; set; }

            public string UserName { get; set; }

            #endregion Properties
        }

        #endregion Classes
    }
}