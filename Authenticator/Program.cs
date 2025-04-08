using System;
using System.Threading;
using Authenticator;


namespace Authenticator
{
    class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(() =>
            {
                var auth1 = Authenticator.Instance;
                auth1.Authenticate("Alice");
            });

            Thread t2 = new Thread(() =>
            {
                var auth2 = Authenticator.Instance;
                auth2.Authenticate("Bob");
            });

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            var authMain = Authenticator.Instance;
            authMain.Authenticate("Charlie");
        }
    }
}