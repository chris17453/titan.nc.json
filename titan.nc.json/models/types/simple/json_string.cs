using System;

namespace titan.nc.json.types{
    public class json_string  {
        private string value { get; set; }
        public json_string(){
        }
        public static implicit operator string(json_string o){
            return o.value;
        }
    }
}
