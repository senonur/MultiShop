using MultiShop.Basket.Dtos;
using MultiShop.Basket.Settings;
using System.Text.Json;

namespace MultiShop.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task DeleteBasket(string userID)
        {
            await _redisService.GetDb().KeyDeleteAsync(userID);
        }

        public async Task<BasketTotalDto> GetBasket(string userID)
        {
            var exisBasket= await _redisService.GetDb().StringGetAsync(userID);
            return JsonSerializer.Deserialize<BasketTotalDto>(exisBasket);
        }

        public async Task  SaveBasket(BasketTotalDto basketTotalDto)
        {
            await _redisService.GetDb().StringSetAsync(basketTotalDto.UserID, JsonSerializer.Serialize(basketTotalDto));
        }
    }
}
