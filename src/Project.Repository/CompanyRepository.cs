using AutoMapper;
using Project.DAL.Entities;
using Project.Models;
using Project.Models.Common;
using Project.Repository.Common;
using System;
using System.Collections.Generic;

namespace Project.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        #region Constructors

        static CompanyRepository()
        {
            Storage = new List<CompanyEntity>();
            Storage.Add(new CompanyEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Company 1",
                Description = "Company 1 Description",
                Balance = 100100.10
            });
            Storage.Add(new CompanyEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Company 2",
                Description = "Company 2 Description",
                Balance = -100000.10
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

        public List<ICompany> Get()
        {
            return new List<ICompany>(Mapper.Map<List<Company>>(CompanyRepository.Storage));
        }

        #endregion Methods
    }
}