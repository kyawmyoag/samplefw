using System.Configuration;

namespace SampleFw.Core
{
    public static class AppSettings
    {
        public static string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString();

        public static string Version = ConfigurationManager.AppSettings["Version"].ToString();
    }
}
