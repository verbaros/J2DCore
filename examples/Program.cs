using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string doc = "";
            using (StreamReader sr = new StreamReader("exammple.json"))
            {
                doc = sr.ReadToEnd();
            }
            var x = JsonConvert.DeserializeObject<Dictionary<string,dynamic>>(doc);
            processJson(x);
            Console.WriteLine(doc);
        }

        static void processJson (Dictionary<string,dynamic> inDict)
        {
            bool isLeaf = true;
            foreach (string key in inDict.Keys)
            {
                dynamic tKey;
                inDict.TryGetValue(key,out tKey);
                string cKey = Convert.ToString(tKey);
                if(cKey.Trim().StartsWith('{'))
                {
                    isLeaf = false;
                    inDict[key] = JsonConvert.DeserializeObject<Dictionary<string,dynamic>>(cKey);
                    processJson(inDict[key]);
                }
            }
        }
    }
}
