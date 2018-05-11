using System;

namespace titan.nc.json.types{
    public class json_decimal {
        private decimal value { get; set; }
        public json_decimal(){
        }
        public static implicit operator decimal(json_decimal o){
            return o.value;
        }
    }
}
