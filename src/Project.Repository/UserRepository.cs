using Project.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Project.Repository
{
    public class UserRepository
    {
        #region Constructors

        static UserRepository()
        {
            Storage = new List<UserEntity>();
            Storage.Add(new UserEntity()
            {
                Id = Guid.NewGuid(),
                UserName = "JohnD",
                FirstName = "John",
                LastName = "Doe"
            });
            Storage.Add(new UserEntity()
            {
                Id = Guid.NewGuid(),
                UserName = "JaneR",
                FirstName = "Jane",
                LastName = "Roe"
            });
        }

        public UserRepository()
        {
        }

        #endregion Constructors

        #region Properties

        public static List<UserEntity> Storage { get; set; }

        #endregion Properties

        #region Methods

        public List<UserEntity> Get()
        {
            return UserRepository.Storage;
        }

        #endregion Methods
    }
}