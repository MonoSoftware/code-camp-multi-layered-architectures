using Project.Models.Common;
using System;
using System.Collections.Generic;

namespace Project.Repository.Common
{
    public interface IUserRepository
    {
        #region Methods

        List<IUser> Get();

        #endregion Methods
    }
}