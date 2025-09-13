using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppArchitectureJWT.Auth
{
    public class AuthSettings
    {
        public string SecretKey { get; set; }  // from appsettings.json
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryInDays { get; set; } = 1;
    }
}
