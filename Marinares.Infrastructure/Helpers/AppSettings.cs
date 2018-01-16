using System;
using System.Configuration;

namespace Marinares.Infrastructure.Helpers
{
    public static class AppSettings
    {
        public static string Host => GetValue<string>("Email.Host");
        public static int Port => GetValue<int>("Email.Port");
        public static string UserName => GetValue<string>("Email.User.Name");
        public static string Password => GetValue<string>("Email.User.Password");
        public static string From => GetValue<string>("Email.From");
        public static string Display => GetValue<string>("Email.DisplayName");


        public static string PayPalUserName { get; set; }
        public static string PayPalPassword { get; set; }
        public static string PayPalSignature { get; set; }
        public static string PayPalUrl { get; set; }
        public static string PayPalCallback { get; set; }


        private static TValue GetValue<TValue>(string appSettingsKey)
        {
            try
            {
                string value = ConfigurationManager.AppSettings[appSettingsKey];
                if (!string.IsNullOrEmpty(value))
                {
                    return (TValue)Convert.ChangeType(value, typeof(TValue));
                }
            }
            catch
            {
                /**/
            }
            return default(TValue);
        }
    }
}