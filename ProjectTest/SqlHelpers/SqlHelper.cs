using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Configuration;
using System.Reflection;

namespace SqlHelpers
{
    public static class SqlHelper
    {
        private static readonly string defaultConnString;
        private static readonly string defaultProviderName;
        public static SqlHelper()
        {
            ConnectionStringSettings settings = GetSettings("TestDB");
            defaultConnString = GetConnectionString(settings);
            defaultProviderName = GetProviderName(settings);      
        }

        private static ConnectionStringSettings GetSettings(string conKey) 
        {
            return ConfigurationManager.ConnectionStrings[conKey];
        }

        private static string GetConnectionString(ConnectionStringSettings settings)
        {
            return settings == null ? string.Empty : settings.ConnectionString;
        }

        private static string GetProviderName(ConnectionStringSettings settings)
        {
            return settings == null ? string.Empty : settings.ProviderName;
        }

    }
}
