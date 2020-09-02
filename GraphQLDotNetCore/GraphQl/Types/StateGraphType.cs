using GraphQL.Types;
using GraphQLDotNetCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQl.Types
{
    public class StateGraphType:ObjectGraphType<State>
    {
        public StateGraphType()
        {
            Name = "State";
            Field(f => f.Id, type: typeof(IdGraphType)).Description("State Id");
            Field(f => f.Name).Description("State Name");
            Field(f => f.GeoPoliticalZoneId, type: typeof(IdGraphType)).Description("GeopoliticalZone Id");
            //Field(f => f.GeoPoliticalZone.Name).Description("GeopoliticalZoneName Name");
        }
    }
}
