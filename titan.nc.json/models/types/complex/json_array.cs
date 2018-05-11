using System;
using System.Collections.Generic;
using System.Text;

namespace titan.nc.json.types{
    public class json_array : List<json_type>
    {
        public json_array(){
        }
        public static implicit operator json_type(json_array o){
            return new json_type(o);
        }
        
        public override string ToString() {
            string line_ending="\r\n";
            StringBuilder o=new StringBuilder();
            o.Append("["+line_ending);
            bool first=true;
            for(int i=0; i<this.Count;i++) {
                if(first) {
                    first=false;
                } else {
                    o.Append(","+line_ending);
                }
                o.Append(this[i].ToString());
            }
            o.Append(line_ending+"]");
            return o.ToString();
        }        
        
    }
}