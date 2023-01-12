using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Models
{
    public class Account : BaseEntity
    {
        [Column(Order = 3)]
        [Required]
        public double Balance { get; set; }

        [Column(Order = 4)]
        [Required]
        public DateTime CreationDate { get; set; }

        [Column(Order = 2)]
        [Required]
        public string Name { get; set; }

        [Column(Order = 1)]
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
