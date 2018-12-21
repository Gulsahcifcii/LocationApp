using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Data.Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public bool Gender { get; set; }
        [DataMember]
        public string NationID { get; set; }
        [DataMember]
        public int UserTitleID { get; set; }
    }
    
    
}
