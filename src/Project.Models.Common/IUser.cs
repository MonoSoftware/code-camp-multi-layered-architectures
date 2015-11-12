using System;

namespace Project.Models.Common
{
    public interface IUser
    {
        #region Properties

        string Description { get; set; }

        string FirstName { get; set; }

        Guid Id { get; set; }

        string LastName { get; set; }

        string Password { get; set; }
        string UserName { get; set; }

        #endregion Properties
    }
}