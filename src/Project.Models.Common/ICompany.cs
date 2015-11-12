using System;

namespace Project.Models.Common
{
    public interface ICompany
    {
        #region Properties

        double Balance { get; set; }
        string Description { get; set; }

        Guid Id { get; set; }

        string Name { get; set; }

        #endregion Properties
    }
}