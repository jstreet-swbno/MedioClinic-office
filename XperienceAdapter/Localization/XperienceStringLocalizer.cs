﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using CMS.Helpers;
using Microsoft.Extensions.Localization;

namespace XperienceAdapter.Localization
{
    public class XperienceStringLocalizer : IStringLocalizer
    {
        private string _cultureName;

        public XperienceStringLocalizer() : this(Thread.CurrentThread.CurrentUICulture) { }

        public XperienceStringLocalizer(CultureInfo culture)
        {
            _cultureName = culture.Name;
        }

        public LocalizedString this[string name]
        {
            get
            {
                var value = GetString(name);

                return new LocalizedString(name, value ?? name, resourceNotFound: value == null);
            }
        }

        public LocalizedString this[string name, params object[] arguments]
        {
            get
            {
                var format = GetString(name);
                var value = string.Format(format ?? name, arguments);

                return new LocalizedString(name, value, resourceNotFound: format == null);
            }
        }

        private string GetString(string key) =>
            ResHelper.GetString(key, Thread.CurrentThread.CurrentUICulture.Name);

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) =>
            throw new NotImplementedException();

        public IStringLocalizer WithCulture(CultureInfo culture) => throw new NotImplementedException();
    }
}
