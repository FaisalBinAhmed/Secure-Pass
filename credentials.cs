using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Credentials
    {
        private string username;
        private string password;
        private string url;
        public Credentials() { }
        public Credentials(string a, string b, string c) { this.username = a; this.password = b; this.url = c; }
        public string getUsername() { return this.username; }

    }
}
