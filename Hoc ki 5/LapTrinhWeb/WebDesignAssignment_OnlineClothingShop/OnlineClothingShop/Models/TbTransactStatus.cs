using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothingShop.Models
{
    [Table("TransactStatus")]
    public partial class TbTransactStatus
    {
        public TbTransactStatus()
        {
            TbOrders = new HashSet<TbOrder>();
        }

        public int TransactStatusId { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<TbOrder> TbOrders { get; set; }
    }
}
