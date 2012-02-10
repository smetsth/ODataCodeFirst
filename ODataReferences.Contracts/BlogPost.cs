using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Services.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ODataReferences.Contracts
{
    [DataServiceKey("Id")]
    [DataContract]
    public class BlogPost
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public ICollection<Comment> Comments { get; set; }
    }

    [DataServiceKey("Id")]
    [DataContract]
    public class Comment
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
