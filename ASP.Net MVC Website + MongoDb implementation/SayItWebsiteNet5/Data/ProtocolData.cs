
using SayItWebsiteNet5.Models;

namespace SayItWebsiteNet5.Data
{
    public class ProtocolData
    {

        public ProtocolData()
        {

        }

        public static ProtocolData EmptyProtocol()
        {

            return new ProtocolData() { Present = false, Note = "Ingen Protokol", StudentData = new Student() };
        }
        public bool Present { get; set; }
        public string? Note { get; set; }
        public Student StudentData { get; set;}
    }
}
