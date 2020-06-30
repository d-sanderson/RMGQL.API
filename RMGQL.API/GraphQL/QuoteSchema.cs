using GraphQL;
using GraphQL.Types;

namespace RMGQL.API.GraphQL
{
    public class QuoteSchema : Schema
    {

        public QuoteSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<QuoteQuery>();
        }
    }
}
