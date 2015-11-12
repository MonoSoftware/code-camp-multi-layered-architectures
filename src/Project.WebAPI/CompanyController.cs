using Project.Service;
using System;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebAPI
{
    public class CompanyController : ApiController
    {
        #region Constructors

        public CompanyController(CompanyService service)
        {
            this.Service = service;
        }

        #endregion Constructors

        #region Properties

        public CompanyService Service { get; set; }

        #endregion Properties

        #region Methods

        [HttpGet]
        [Route("companies")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(Service.Get());
        }

        #endregion Methods
    }
}