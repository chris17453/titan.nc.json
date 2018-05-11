using System;

namespace titan.nc.json.types{
    public class json_bool{
        private bool value { get; set; }
        public json_bool(){
        }
        public json_bool(bool data){
            value=data;
        }
        public static implicit operator bool(json_bool o){
            return o.value;
        }
        public static implicit operator json_type(json_bool o){
            return new json_type(o);
        }

		public override string ToString() {
			return value.ToString();
		}

	}
}
