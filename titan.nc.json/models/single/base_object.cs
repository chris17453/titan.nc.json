using System;
using System.Collections;
using System.Collections.Generic;

namespace titan.nc.json.models.single {
    
   


    public class base_object {
        public  object_type         type      { get; set; }
        public  string              parent    { get; set; }
        public  string              name      { get; set; }
        public  object              value     { get; set; }
        private Dictionary<string,base_object>   o_value   { get; set; }
        private List<base_object>   lo_value  { get; set; }
        private decimal             d_value   { get; set; }
        private bool                b_value   { get; set; }
        private int                 i_value   { get; set; }
        private string              s_value   { get; set; }
        
        public base_object()  {
        }
        
        public base_object(string name,object_type type) {
            this.name   =name;
            this.type   =type;
        }
        public string Add(base_object o){
            if(this.type==object_type.@object) {
                if(String.IsNullOrWhiteSpace(o.name)) return null;
                if(null==o_value) o_value=new Dictionary<string,base_object>();
                o_value[o.name]=o;
                return o.name;
            }
            if(this.type==object_type.array) {
                if(null==lo_value) lo_value=new List<base_object>();
                string name=lo_value.Count.ToString();
                lo_value.Add(o);
                return name;
            }            
            return null;
        }
        public base_object(string name,object_type type,object value) {
            this.name   =name;
            this.type   =type;
         //   if(String.IsNullOrWhiteSpace(json_data)) return;
/*            switch(type) {
                case object_type.@bool    : b_value=   (bool)json_data; break;
                case object_type.@decimal : d_value=(decimal)json_data; break;
                case object_type.@int     : i_value=    (int)json_data; break;
                case object_type.@object  : o_value=         json_data; break;
                case object_type.@string  : s_value= (string)json_data; break;
                case object_type.array    : lo_value=(List<object>)json_data; break;
            }*/
        }
    }
}

