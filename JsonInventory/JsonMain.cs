using JsonInventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonInvertory
{
    public class JSONMain
    {
        Model inventory = new Model();
        List<Model> inventoryList = new List<Model>();
        public void convert(string jFilepath)
        {
            using (StreamReader reader = new StreamReader(jFilepath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Name Weight Price Total Value");
                foreach (var item in items)
                {
                    double value = item.price * item.weight;
                    Console.WriteLine(item.name + " " + item.weight + " " + item.price + " " + value);
                }
            }
        }

    }

}