using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Models
{
    public class User : BaseEntity
    {
        public ICollection<Account> Accounts { get; set; }

        [Column(Order = 4)]
        [Required]
        public DateTime CreationDate { get; set; }

        [Column(Order = 2)]
        [Required]
        public string Email { get; set; }

        [Column(Order = 1)]
        [Required]
        public string Name { get; set; }

        [Column(Order = 3)]
        [Required]
        public string Password { get; set; }
    }
}