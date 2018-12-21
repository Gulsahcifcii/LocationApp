using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace LocationApp.Data.Dto
{
    [DataContract]
    public class UserPasswordDto
    {
        [DataMember]
        public int userPasswordID { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public int userID { get; set; }
    }
}
