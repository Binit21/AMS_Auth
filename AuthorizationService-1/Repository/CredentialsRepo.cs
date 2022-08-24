using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public class CredentialsRepo: ICredentialsRepo
    {
        private Dictionary<string, string> ValidUsersDictionary = new Dictionary<string, string>()
        {
               {"admin","admin"},
               {"binit","binit"}
        };
        public Dictionary<string,string> GetCredentials()
        {
            return ValidUsersDictionary;
        }
    }
}
