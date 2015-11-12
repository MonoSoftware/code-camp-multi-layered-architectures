using Project.Models.Common;
using Project.Repository.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;

namespace Project.Service
{
    public class CompanyService : ICompanyService
    {
        #region Constructors

        public CompanyService(ICompanyRepository repository)
        {
            this.Repository = repository;
        }

        #endregion Constructors

        #region Properties

        protected ICompanyRepository Repository { get; private set; }

        #endregion Properties

        #region Methods

        public List<ICompany> Get()
        {
            return Repository.Get();
        }

        #endregion Methods
    }
}