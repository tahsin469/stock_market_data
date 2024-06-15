using Microsoft.EntityFrameworkCore;

namespace stock_market_data.Models
{
    public class TradeDbContext : DbContext
    {
        public TradeDbContext(DbContextOptions<TradeDbContext> options) : base(options)
        {

        }
        //DB Table Name
        public DbSet<TradeData> TradeDatas { get; set; }
    }
}
