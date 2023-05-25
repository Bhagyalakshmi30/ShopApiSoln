using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApi.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        
       
        public Customers  Customer { get; set; }
        [Required]
        public decimal OrderAmount { get; set; }
        [Required]
        
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        public int  ProductId { get; set; }
        
        //navigation
        //public Customers customerid { get; set; }
        //    public Products productid { get; set; }
    }
}
