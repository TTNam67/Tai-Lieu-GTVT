using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothingShop.Models
{
    [Table("tb_Categories")]
    public partial class TbCategory
    {
        public TbCategory()
        {
            TbProducts = new HashSet<TbProduct>();
        }

        public int CatId { get; set; }
        public string? CatName { get; set; }
        public string? Thumb { get; set; }

        public virtual ICollection<TbProduct> TbProducts { get; set; }
    }
}
