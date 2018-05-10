using System;
using System.Collections.Generic;
using  titan.nc.json.models.single;


namespace titan.nc.json.models {
    public static class mutable {
        public static base_object mutable(string data) {
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
            int name_index=0;
            string name=String.Empty;;
            //objects.Add(root);
            for(int i=0;i<len;i++){
                char c=data[i];
                
                if(c=='\"') {
                    if(in_quote==true)  in_quote=false; 
                    else                in_quote=true; 
                    continue;
                } 
                    
                    
                switch(c){
                    case '{'  : make_new_object=true; ++depth; type=object_type.@object; name_index=i;  break;
                    case ':'  : make_new_object=true; name=data.Substring(name_index,i-name_index); break;
                    case '}'  : make_new_object=true; --depth; break;
                    case ','  : make_new_object=true; ++node; break;
                    case '['  : make_new_object=true; type=object_type.@array; break;
                    case ']'  : make_new_object=true; type=object_type.none;   break;
                }
                if(make_new_object) {
                    last=curent;
                    curent=new base_object(name,type);
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
