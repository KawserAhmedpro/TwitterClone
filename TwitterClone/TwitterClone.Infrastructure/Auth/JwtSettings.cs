using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Infrastructure.Auth
{
    public  class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpirationInMinutes { get; set; }
    }
}
