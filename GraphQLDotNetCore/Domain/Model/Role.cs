using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.Domain.Model
{
    public class Role:BaseModel
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
