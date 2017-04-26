using Newtonsoft.Json;
using RimotrAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rimotr_Client
{
    class Program : MyReceiver
    {
        static void Main()
        {
            SetURI("localhost:6969");

            var json = JsonConvert.SerializeObject(new { hello = "world" });

            var receivedData = GetData(json);

            Console.WriteLine(json);
            Console.WriteLine(receivedData);
        }
    }
}
