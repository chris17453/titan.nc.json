using System;

namespace titan.nc.json.types{
    public class json_string  {
        private string value { get; set; }
        public json_string(){
        }
        public json_string(string data){
            value=data;
        }
        public static implicit operator string(json_string o){
            return o.value;
        }
        public static implicit operator json_type(json_string o){
            return new json_type(o);
        }
        public override string ToString() {
            return "\""+value.ToString()+"\"";
        }
    }
}
