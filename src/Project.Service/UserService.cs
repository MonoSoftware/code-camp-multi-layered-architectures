using Project.DAL.Entities;
using Project.Repository;
using System;
using System.Collections.Generic;

namespace Project.Service
{
    public class UserService
    {
        #region Constructors

        public UserService(UserRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors

        #region Properties

        public UserRepository Repository { get; set; }

        #endregion Properties

        #region Methods

        public List<UserEntity> Get()
        {
            return Repository.Get();
        }

        #endregion Methods
    }
}