using Project.Models.Common;
using System;
using System.Collections.Generic;

namespace Project.Service.Common
{
    public interface ICompanyService
    {
        #region Methods

        List<ICompany> Get();

        #endregion Methods
    }
}