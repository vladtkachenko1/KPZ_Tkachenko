using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticator
{
    using System;

    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance =
            new Lazy<Authenticator>(() => new Authenticator());

        private Authenticator()
        {
            Console.WriteLine("Authenticator created");
        }

        public static Authenticator Instance => _instance.Value;

        public void Authenticate(string user)
        {
            Console.WriteLine($"Authenticating user: {user}");
        }
    }

}
