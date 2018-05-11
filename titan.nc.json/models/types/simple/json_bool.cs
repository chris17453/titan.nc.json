using System;

namespace titan.nc.json.types{
    public class json_bool{
        private bool value { get; set; }
        public json_bool(){
        }
        public static implicit operator bool(json_bool o){
            return o.value;
        }
    }
}
