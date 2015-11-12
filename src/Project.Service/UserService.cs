using Project.Models.Common;
using Project.Repository.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;

namespace Project.Service
{
    public class UserService : IUserService
    {
        #region Constructors

        public UserService(IUserRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors

        #region Properties

        protected IUserRepository Repository { get; private set; }

        #endregion Properties

        #region Methods

        public List<IUser> Get()
        {
            return Repository.Get();
        }

        #endregion Methods
    }
}