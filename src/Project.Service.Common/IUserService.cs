using Project.Models.Common;
using System;
using System.Collections.Generic;

namespace Project.Service.Common
{
    public interface IUserService
    {
        #region Methods

        List<IUser> Get();

        #endregion Methods
    }
}