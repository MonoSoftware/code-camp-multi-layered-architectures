using Project.DAL.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Project.Service;
using Moq;
using Xunit;
using Project.Repository;

namespace Project.Service.Tests
{
    public class UserServiceTest
    {
        #region Fields

        private UserServiceFixture fixture;

        #endregion Fields

        #region Constructors

        public UserServiceTest()
        {
            fixture = new UserServiceFixture();
        }

        #endregion Constructors

        #region Methods

        [Fact]
        public void service_user_service_get_test()
        {
            fixture.Target.Should().NotBeNull();

            fixture.Target.Get().Should().BeEmpty();
        }

        #endregion Methods

        #region Classes

        private class UserServiceFixture
        {
            #region Constructors

            public UserServiceFixture()
            {
                UserRepository = new Mock<UserRepository>();
                UserRepository.Setup(p => p.Get()).Returns(new List<UserEntity>());

                Target = new UserService(UserRepository.Object);
            }

            #endregion Constructors

            #region Properties

            public UserService Target { get; set; }
            public Mock<UserRepository> UserRepository { get; set; }

            #endregion Properties
        }

        #endregion Classes

    }
}