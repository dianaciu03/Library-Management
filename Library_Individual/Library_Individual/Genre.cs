using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library_Individual
{
    [DataContract]
    public enum Genre
    {
        [EnumMember] Fiction,
        [EnumMember] NonFiction,
        [EnumMember] Romance,
        [EnumMember] Mystery,
        [EnumMember] ScienceFiction,
        [EnumMember] Fantasy,
        [EnumMember] Childrens,
        [EnumMember] Poetry,
        [EnumMember] Biography
    }

}
