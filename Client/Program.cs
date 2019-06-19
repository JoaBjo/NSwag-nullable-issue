using System;
using System.Diagnostics;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new DemoClient(new System.Net.Http.HttpClient());
            client.GetNullableIntAsync().GetAwaiter().GetResult();  // works
            client.GetNullableStructAsync().GetAwaiter().GetResult();  // throws exception
        }
    }
}
