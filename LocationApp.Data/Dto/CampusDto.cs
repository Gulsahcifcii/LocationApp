using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Data.Dto
{
    [DataContract]
    public class CampusDto
    {
        public int CampusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Other { get; set; }
    }
}
