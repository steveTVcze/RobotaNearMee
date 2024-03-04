using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotaNearMe.Lib.Modelos
{
    public class FileTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public Guid UserId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime Added { get; set; }
    }
}
