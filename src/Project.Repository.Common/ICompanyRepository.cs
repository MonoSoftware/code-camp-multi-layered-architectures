using Project.Models.Common;
using System;
using System.Collections.Generic;

namespace Project.Repository.Common
{
    public interface ICompanyRepository
    {
        #region Methods

        List<ICompany> Get();

        #endregion Methods
    }
}