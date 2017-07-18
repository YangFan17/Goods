using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Goods
    {
        public int ID { get; set; }
        [Display(Name = "商品名称")]
        public string Name { get; set; }
        [Display(Name = "生产日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Display(Name = "类别")]
        public string Genre { get; set; }
        [Display(Name = "价格")]
        public decimal Price { get; set; }
    }
    public class GoodsDBContext : DbContext
    {
        public DbSet<Goods> Goods { get; set; }
    }
}