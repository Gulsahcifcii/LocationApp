using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Data.Dto
{
    [DataContract]
    public class SubUnitDto
    {
        [DataMember]
        public int SubUnitID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int MainUnitID { get; set; }
    }
}
