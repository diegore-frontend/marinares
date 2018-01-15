using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Marinares.Data.Shared
{
    public class EmailData
    {
        public string From { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<string> To { get; set; }
        public string Subcaject { get; set; }
        public string Body { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        public Credentiales Credentiales { get; set; }
    }

    public class Credentiales
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}