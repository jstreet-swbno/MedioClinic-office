﻿using CMS.Base;
using CMS.Helpers;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XperienceAdapter.Services
{
    /// <summary>
    /// Common repository dependencies.
    /// </summary>
    public interface IRepositoryServices
    {
        ISiteService SiteService { get; }

        ISiteContextService SiteContextService { get; }

        IPageRetriever PageRetriever { get; }

        IPageUrlRetriever PageUrlRetriever { get; }

        IPageAttachmentUrlRetriever PageAttachmentUrlRetriever { get; }

        ISiteCultureRepository SiteCultureRepository { get; }

        IProgressiveCache ProgressiveCache { get; }
    }
}