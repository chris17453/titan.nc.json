using System;

namespace test {
    class Program {
        static void Main(string[] args) {
            string file="/home/ng/repos/kafka-project/schema.dev.box.engagement.event.ExternalEngagementCreated.json";
            titan.nc.jsonschema.load_from_file(file);
        }
    }
}
