 using System;
using System.Collections.Generic;
using  titan.nc.json.models.single;
using  titan.nc.json.types;


namespace titan.nc.json.models {
    public static class mutable {
        public static base_object build(string root_name,string data) {
            uint    len         =(uint)data.Length;
            uint    depth       =0;
            uint    node        =0;
            bool    in_quote    =false;
            bool    in_name     =false;
            bool    in_value    =false;
            bool    in_array    =false;
            bool make_new_object=false;
            base_object root    =null;
            base_object curent  =null;
            base_object last    =null;
            object_type type    =object_type.@object;
            int last_index=0;
            string name=String.Empty;;
            //objects.Add(root);
            for(int i=0;i<len;i++){
                char c=data[i];
                
                if(c=='\"') {
                    if(in_quote==true)  in_quote=false; 
                    else                in_quote=true; 
                    continue;
                } 

                if(in_quote) continue;
                    
                    
                switch(c){
                    case '{'  : make_new_object=true; in_name=true;  in_value=false;  ++depth; type=object_type.@object; last_index=i;  break;
                    case ':'  : make_new_object=false; in_name=false; in_value=true;   name=data.Substring(last_index,i-last_index); last_index=i; break;
                    case '}'  : make_new_object=true; in_name=false; in_value=false; --depth; last_index=i; break;
                    case ','  : make_new_object=true; in_name=true;  in_value=false;  ++node;  last_index=i; break;
                    case '['  : make_new_object=true; in_name=false; in_value=false;  type=object_type.@array; last_index=i; break;
                    case ']'  : make_new_object=true; in_name=false; in_value=false;  type=object_type.none;   last_index=i; break;
                }
                if(make_new_object) {
                    make_new_object=false;
                    last=curent;
                    if(root==null) name=root_name;
                    //curent=new json_type(type,);
                    if(null!=last) { 
                        if(last.type==object_type.array ||
                           last.type==object_type.@object) {
                            last.Add(curent);
                            name=null;
                        } else {
                            last.value=curent;
                        }
                    } else {
                        if(null==root)  root=curent;
                    }
                                        
                }
                //if we have an object and root is set. reference it.  it's the anchor
                
            }
            return root;
        }//end funciton
    }//end class
}//end namespace
