using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XperienceAdapter.Localization
{
    public class XperienceStringLocalizerFactory : IStringLocalizerFactory
    {
        public IStringLocalizer Create(Type resourceSource) =>
            new XperienceStringLocalizer();

        public IStringLocalizer Create(string baseName, string location) =>
            new XperienceStringLocalizer();
    }
}
