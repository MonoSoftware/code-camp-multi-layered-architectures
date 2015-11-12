using Project.DAL.Entities;
using Project.Repository;
using System;
using System.Collections.Generic;

namespace Project.Service
{
    public class CompanyService
    {
        #region Constructors

        public CompanyService(CompanyRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors

        #region Properties

        protected CompanyRepository Repository { get; private set; }

        #endregion Properties

        #region Methods

        public List<CompanyEntity> Get()
        {
            return Repository.Get();
        }

        #endregion Methods
    }
}