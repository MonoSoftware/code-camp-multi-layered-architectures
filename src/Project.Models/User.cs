using Project.Models.Common;
using System;

namespace Project.Models
{
    public class User : IUser
    {
        #region Properties

        public string Description { get; set; }

        public string FirstName { get; set; }

        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }
        public string UserName { get; set; }

        #endregion Properties
    }
}