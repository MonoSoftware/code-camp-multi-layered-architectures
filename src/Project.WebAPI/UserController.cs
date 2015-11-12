using Project.Service;
using System;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebAPI
{
    public class UserController : ApiController
    {
        #region Constructors

        public UserController(UserService service)
        {
            this.Service = service;
        }

        #endregion Constructors

        #region Properties

        public UserService Service { get; set; }

        #endregion Properties

        #region Methods

        [HttpGet]
        [Route("user")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(Service.Get());
        }

        #endregion Methods
    }
}