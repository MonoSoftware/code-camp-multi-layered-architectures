using System;

namespace Project.DAL.Entities
{
    public class CompanyEntity
    {
        #region Properties

        public double Balance { get; set; }
        public string Description { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}