﻿using DataApp.Core.Abstracts;
using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataApp.Core.DAL;

namespace DataApp.Core.Controllers
{
    public class ProjectController: Controller<Project>,IAddData<Project>,IReadData<Project>,IModifyData<Project>
    {
        public ProjectController(DataAppContext dbContext)
            :base(dbContext)
        {
        }

        public bool Add(Project entity)
        {
            return this.repo.Add(entity);
        }

        public bool Update(Project entity)
        {
            return this.repo.Update(entity);
        }

        public Project Get(Func<Project, bool> filter)
        {
            return this.repo.Get(filter);
        }

        public List<Project> GetAll(Func<Project, bool> filter = null)
        {
            return this.repo.GetAll(filter);
        }
    }
}
