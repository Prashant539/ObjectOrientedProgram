using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonInvertory
{
    internal class JSONMain
    {
        Model Invontory = new Model();
        List<Model> InvontoryList= new List<Model>();
        public void convert (string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Name Weight Price Total Value");
                foreach (var item in items)
                {
                    double value = item.price * item.weight ;
                    Console.WriteLine(item.name + " "+ item.price + ""+ item.weight + ""+ value);
                }
            }
        }

    }

}
