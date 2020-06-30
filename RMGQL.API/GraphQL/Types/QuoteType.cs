using GraphQL.Types;
using RMGQL.API.Data.Entities;


namespace RMGQL.API.GraphQL.Types
{
    public class QuoteType : ObjectGraphType<Quote>
    {

        public QuoteType()
        {
            Field(t => t.Id);
            Field(t => t.Character).Description("Who said it");
            Field(t => t.Excerpt).Description("What the character said");
            Field(t => t.Episode).Description("The Episode the character said it");

        }
    }
}
