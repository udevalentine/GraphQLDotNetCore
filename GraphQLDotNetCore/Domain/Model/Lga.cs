using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.Domain.Model
{
    public class Lga:BaseModel
    {
        public long StateId { get; set; }
        public virtual State State { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
