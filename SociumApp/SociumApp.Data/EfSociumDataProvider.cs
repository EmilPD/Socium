﻿using SociumApp.Data.Contracts;
using SociumApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SociumApp.Data
{
    public class EfSociumDataProvider : IEfSociumDataProvider
    {
        private ISociumDbContext dbContext;

        public EfSociumDataProvider(ISociumDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.Questions = new EfRepository<Question>(this.dbContext);
            this.Options = new EfRepository<Option>(this.dbContext);
            this.Users = new EfRepository<ApplicationUser>(this.dbContext);
            this.Votes = new EfRepository<Vote>(this.dbContext);
        }

        public int Commit()
        {
            return this.dbContext.SaveChanges();
        }

        public IEfRepository<Question> Questions { get; private set; }

        public IEfRepository<Option> Options { get; private set; }

        public IEfRepository<ApplicationUser> Users { get; private set; }

        public IEfRepository<Vote> Votes { get; private set; }
    }
}
