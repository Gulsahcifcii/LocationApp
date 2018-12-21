using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Data.Dto
{
    [DataContract]
    public class RoomDto
    {
        [DataMember]
        public int RoomID { get; set; }
        [DataMember]
        public int FloorID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int RoomTypeID { get; set; }
        [DataMember]
        public string Map { get; set; }
    }
}
