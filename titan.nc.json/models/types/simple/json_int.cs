using System;

namespace titan.nc.json.types{
    public class json_int {
        private int value { get; set; }
        public json_int(){
        }
        public json_int(int data){
            value=data;
        }
        public static implicit operator int(json_int o){
            return o.value;
        }
        public static implicit operator json_type(json_int o){
            return new json_type(o);
        }
        public override string ToString() {
            return value.ToString();
        }
        
    }
}
