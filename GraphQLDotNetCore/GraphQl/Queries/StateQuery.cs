using GraphQL;
using GraphQL.Types;
using GraphQLDotNetCore.Domain.Model;
using GraphQLDotNetCore.GraphQl.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQl.Queries
{
    public class StateQuery:ObjectGraphType
    {
        private readonly MyAppContext _myAppContext;
        public StateQuery(MyAppContext myAppContext)
        {
            _myAppContext = myAppContext;
            Name = "Query";
            Field<ListGraphType<StateGraphType>>("States", "Returns a list of States", resolve: context => _myAppContext.STATE.ToList());
            Field<StateGraphType>("State", "Returns a single State", new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "State Id" }),
                context => _myAppContext.STATE.Single(f => f.Id == context.Arguments["id"].GetPropertyValue<long>()));
        }
    }
}
