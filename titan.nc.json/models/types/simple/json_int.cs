using System;

namespace titan.nc.json.types{
    public class json_int {
        private int value { get; set; }
        public json_int(){
        }
        public static implicit operator int(json_int o){
            return o.value;
        }
    }
}
