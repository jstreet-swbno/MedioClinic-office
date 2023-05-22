using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XperienceAdapter.Services
{
    /// <summary>
    /// Captures information related the current site.
    /// </summary>
    public interface ISiteContextService : IService
    {
        /// <summary>
        /// Indicates if preview mode is enabled.
        /// </summary>
        bool IsPreviewEnabled { get; }
    }
}
