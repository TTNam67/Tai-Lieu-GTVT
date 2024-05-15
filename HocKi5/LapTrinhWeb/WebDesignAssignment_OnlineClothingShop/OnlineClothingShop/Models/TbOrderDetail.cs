using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothingShop.Models
{
    [Table("tb_OrderDetails")]
    public partial class TbOrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderNumber { get; set; }
        public int? Quantity { get; set; }
        public int? Discount { get; set; }
        public int? Total { get; set; }
        public DateTime? ShipDate { get; set; }

        public virtual TbOrder? Order { get; set; }
        public virtual TbProduct? Product { get; set; }
    }
}
