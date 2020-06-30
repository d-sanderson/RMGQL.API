using System.ComponentModel.DataAnnotations.Schema;
namespace RMGQL.API.Data.Entities
{
    public class Quote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Excerpt { get; set; }
        public string Character { get; set; }
        public string Episode { get; set; }
    }
}
