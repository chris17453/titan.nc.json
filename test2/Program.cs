using System;
using titan.nc.json;
using titan.nc.json.models.single;
namespace test2 {
    class Program {
        static void Main(string[] args) {
            string file="/home/nd/repos/kafka-project/jsonschema/schema.dev.box.account-management.event.AccountCreated.json";
            base_object obj_schema=schema.from_file(file);

        }
    }
}
