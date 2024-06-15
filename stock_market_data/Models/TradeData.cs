using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_market_data.Models
{
    public class TradeData
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("date", TypeName = "date")]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Required]
        public DateTime Date { get; set; }

        [Column("trade_code", TypeName = "varchar(50)")]
        [Required]
        public string TradeCode { get; set; }

        [Column("hight", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal High { get; set; }

        [Column("low", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Low { get; set; }

        [Column("open", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Open { get; set; }

        [Column("close", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Close { get; set; }

        [Column("volume", TypeName = "int")]
        [Required]
        public int Volume { get; set; }

    }
}
