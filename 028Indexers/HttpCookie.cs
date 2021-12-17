using System;
using System.Collections.Generic;

namespace _028Indexers
{
    public class HttpCookie
    {

        private Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }



        public string this[string key]   /*this is indexer*/
        {
            get { 
            return _dictionary[key];
            }
            set {
            _dictionary[key] = value;
            }
        }

    }
}
