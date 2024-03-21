namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        public int couponId { get; set; }
        public string Couponcode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
