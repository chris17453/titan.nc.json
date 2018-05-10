using System;
using titan.nc.json.models.many;
using titan.nc.json.models.single;

namespace titan.nc.json.models {
    public class json4_base : properties {   
        definitions definitions { get; set; }
        public json4_base(){
        }
        public json4_base(string name,string json_string){
            //base_object o=new base_object(name,json_string); 
            
        }
    }
}
