using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XperienceAdapter.Models;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Repositories
{
    /// <summary>
    /// Stores pages without page type-specific data (coupled data).
    /// </summary>
    public class BasicPageRepository : BasePageRepository<BasicPage, TreeNode>
    {
        public BasicPageRepository(IRepositoryServices repositoryDependencies) : base(repositoryDependencies)
        {
        }
    }
}
