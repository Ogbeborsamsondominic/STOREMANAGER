using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.WriteOrReadJson
{
     class ReadFromJson
    {

        public List<User> ReadFromJsons(string fileName)
        {
            string path = JsonHelper.GetPath(fileName);

            string jsonContent = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<User>>(jsonContent);

        }
    }
}
