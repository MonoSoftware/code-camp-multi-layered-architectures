using Project.Models.Common;
using System;

namespace Project.Models
{
    public class Company : ICompany
    {
        #region Properties

        public double Balance { get; set; }
        public string Description { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}