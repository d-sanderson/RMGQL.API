using GraphQL.Types;
using RMGQL.API.GraphQL.Types;
using RMGQL.API.Repositories;

namespace RMGQL.API.GraphQL
{
    public class QuoteQuery : ObjectGraphType
    {
        public QuoteQuery(QuoteRepository quoteRepository)
        {
            Field<ListGraphType<QuoteType>>(
                "quotes",
                resolve: context => quoteRepository.GetAll()
            );
        }
    }
}
