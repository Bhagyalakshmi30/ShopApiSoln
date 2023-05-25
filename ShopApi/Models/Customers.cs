using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApi.Models
{
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CustomerName { get; set; }
        [Required]
        [StringLength(100)]
        public string? Email { get; set; }


        //navigation
        //public ICollection<Orders> Orders { get; set; }
    }
}
