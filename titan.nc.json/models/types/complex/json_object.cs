using System;
using System.Collections.Generic;
using System.Text;

namespace titan.nc.json.types{
    public class json_object : Dictionary<string, json_type>{
        
        public json_object()
        {
        }
        public static implicit operator json_type(json_object o){
            return new json_type(o);
        }


		public override string ToString() {
            string line_ending="\r\n";
            StringBuilder o=new StringBuilder();
            o.Append("{"+line_ending);
            bool first=true;
            foreach(string key in this.Keys) {
                if(first) {
                    first=false;
                } else {
                    o.Append(","+line_ending);
                }
                o.Append(" \""+key+"\"");
                o.Append(" : ");
                o.Append(this[key].ToString());
                
                
		    }
            o.Append(line_ending+"}");
            return o.ToString();
        }

	}
}
