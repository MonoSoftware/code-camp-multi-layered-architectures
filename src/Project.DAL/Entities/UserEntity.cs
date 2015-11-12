using System;

namespace Project.DAL.Entities
{
    public class UserEntity
    {
        #region Properties

        public string Description { get; set; }

        public string FirstName { get; set; }

        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        #endregion Properties
    }
}