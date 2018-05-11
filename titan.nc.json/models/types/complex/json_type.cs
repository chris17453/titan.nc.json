using System;

namespace titan.nc.json.types{
    public class json_type{
        private object_type type { get; set; }
        private json_int     i_value { get; set; }
        private json_bool    b_value { get; set; }
        private json_decimal d_value { get; set; }
        private json_string  s_value { get; set; }
        private json_object  o_value { get; set; }
        private json_array   a_value { get; set; }



        public json_type(json_int o) {
            type=object_type.@int;
            i_value=o;
        }
        public json_type(json_bool o) {
            type=object_type.@bool;
            b_value=o;
        }
        public json_type(json_decimal o) {
            type=object_type.@decimal;
            d_value=o;
        }
        public json_type(json_string o) {
            type=object_type.@string;
            s_value=o;
        }
        public json_type(json_array o) {
            type=object_type.array;
            a_value=o;
        }
        public json_type(json_object o) {
            type=object_type.@object;
            o_value=o;
        }


        public static implicit operator json_int(json_type o){
            if(o.type==object_type.@int) return o.i_value;
            throw new InvalidCastException("Wrong JSON type, not a json_int");
        }

        public static implicit operator json_decimal(json_type o){
            if(o.type==object_type.@decimal) return o.d_value;
            throw new InvalidCastException("Wrong JSON type, not a json_decimal");
        }
        public static implicit operator json_string(json_type o){
            if(o.type==object_type.@string) return o.s_value;
            throw new InvalidCastException("Wrong JSON type, not a json_string");
        }
        public static implicit operator json_bool(json_type o){
            if(o.type==object_type.@bool) return o.b_value;
            throw new InvalidCastException("Wrong JSON type, not a json_bool");
        }
        public static implicit operator json_array(json_type o){
            if(o.type==object_type.array) return o.a_value;
            throw new InvalidCastException("Wrong JSON type, not a json_array");
        }
        public static implicit operator json_object(json_type o){
            if(o.type==object_type.@object) return o.o_value;
            throw new InvalidCastException("Wrong JSON type, not a json_object");
        }
    }
}
