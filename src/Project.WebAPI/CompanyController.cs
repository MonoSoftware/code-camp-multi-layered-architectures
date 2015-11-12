using AutoMapper;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebAPI
{
    public class CompanyController : ApiController
    {
        #region Constructors

        public CompanyController(ICompanyService service)
        {
            this.Service = service;
        }

        #endregion Constructors

        #region Properties

        public ICompanyService Service { get; set; }

        #endregion Properties

        #region Methods

        [HttpGet]
        [Route("companies")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(Mapper.Map<List<Company>>(Service.Get()));
        }

        #endregion Methods

        #region Classes

        public class Company
        {
            #region Properties

            public string Description { get; set; }

            public Guid Id { get; set; }

            public string Name { get; set; }

            #endregion Properties
        }

        #endregion Classes
    }
}