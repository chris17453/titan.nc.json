using System;
using titan.nc.json.models;
using titan.nc.json.models.many;
using titan.nc.json.models.single;

namespace titan.nc.json {
    public class jsons4: properties {   
        definitions definitions { get; set; }
        public base_object  raw { get; set; }
        public jsons4(){
        }
        public jsons4(string name,string json_string){
            raw=mutable.build("root",json_string);
            
        }
    }
}
