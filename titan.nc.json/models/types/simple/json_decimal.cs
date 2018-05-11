using System;

namespace titan.nc.json.types{
    public class json_decimal {
        private decimal value { get; set; }
        public json_decimal(){
        }
        public json_decimal(decimal data){
            value=data;
        }
        public static implicit operator decimal(json_decimal o){
            return o.value;
        }
        public static implicit operator json_type(json_decimal o){
            return new json_type(o);
        }

        public override string ToString() {
            return value.ToString();
        }
    }
}
