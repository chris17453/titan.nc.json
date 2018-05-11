using System;
using System.IO;
using titan.nc.json.models.single;
namespace titan.nc.json
{
    public class schema
    {
        public static base_object from_file(string file){
            string json_string=File.ReadAllText(file);
            base_object o=models.mutable.build("root",json_string);
            return o;
        }
    }
}


