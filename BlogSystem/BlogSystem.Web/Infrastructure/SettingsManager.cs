﻿using System;
using System.Collections.Generic;

namespace BlogSystem.Web.Infrastructure
{
    public class SettingsManager
    {
        private readonly Lazy<IDictionary<string, string>> settings;

        public SettingsManager(Func<IDictionary<string, string>> initializer)
        {
            this.settings = new Lazy<IDictionary<string, string>>(initializer);
        }

        public IDictionary<string, string> Get => this.settings.Value;
    }
}
