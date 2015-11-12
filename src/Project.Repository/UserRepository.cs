using AutoMapper;
using Project.DAL.Entities;
using Project.Models;
using Project.Models.Common;
using Project.Repository.Common;
using System;
using System.Collections.Generic;

namespace Project.Repository
{
    public class UserRepository : IUserRepository
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
                LastName = "Doe",
                Password = "JohnDPassword"
            });
            Storage.Add(new UserEntity()
            {
                Id = Guid.NewGuid(),
                UserName = "JaneR",
                FirstName = "Jane",
                LastName = "Roe",
                Password = "JaneRPassword"
            });

            Mapper.CreateMap<UserEntity, IUser>().ReverseMap();
        }

        public UserRepository()
        {
        }

        #endregion Constructors

        #region Properties

        public static List<UserEntity> Storage { get; set; }

        #endregion Properties

        #region Methods

        public List<IUser> Get()
        {
            return new List<IUser>(Mapper.Map<List<User>>(UserRepository.Storage));
        }

        #endregion Methods
    }
}