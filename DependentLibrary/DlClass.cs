using System;
using Newtonsoft.Json.Linq;

namespace DependentLibrary
{
    public class DlClass
    {
        public void Do()
        {
            Console.WriteLine("Done something");
            var json = JObject.Parse("{}");
            Console.WriteLine(json.ToString());
        }
    }
}
