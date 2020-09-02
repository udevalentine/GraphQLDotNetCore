using GraphQL;
using GraphQL.Types;
using GraphQLDotNetCore.GraphQl.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQl
{
    public class GraphSchema:Schema
    {
        public GraphSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<StateQuery>();
        }
    }
}
