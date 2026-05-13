namespace MultiShop.Basket.Dtos
{
    public class BasketTotalDto
    {
        public string UserID { get; set; }
        public string Discount { get; set; }
        public int? DiscountDto { get; set; }
        public List<BasketItemDto> BasketItems { get; set; }
        public decimal TotalPrice { get=>BasketItems.Sum(x=>x.Price*x.Quantity);  }
    }
}
