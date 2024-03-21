using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        [Key]
        public int couponId { get; set; }
        [Required]
        public string Couponcode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}

