using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Models
{
    public class BaseEntity
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
