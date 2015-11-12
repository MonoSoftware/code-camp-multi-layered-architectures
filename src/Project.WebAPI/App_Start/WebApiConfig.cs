using System;
using System.Web.Http;

namespace Project.WebAPI
{
    /// <summary>
    /// WebAPI Configuration initializer.
    /// </summary>
    public static class WebApiConfig
    {
        #region Methods

        /// <summary>
        /// Register WebAPI.
        /// </summary>
        /// <param name="config">HTTP configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }

        #endregion Methods
    }
}