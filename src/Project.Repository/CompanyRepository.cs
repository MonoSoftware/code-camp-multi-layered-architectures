using Project.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Project.Repository
{
    public class CompanyRepository
    {
        #region Constructors

        static CompanyRepository()
        {
            Storage = new List<CompanyEntity>();
            Storage.Add(new CompanyEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Company 1",
                Description = "Company 1 Description"
            });
            Storage.Add(new CompanyEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Company 2",
                Description = "Company 2 Description"
            });
        }

        public CompanyRepository()
        {
        }

        #endregion Constructors

        #region Properties

        public static List<CompanyEntity> Storage { get; set; }

        #endregion Properties

        #region Methods

        public List<CompanyEntity> Get()
        {
            return CompanyRepository.Storage;
        }

        #endregion Methods
    }
}