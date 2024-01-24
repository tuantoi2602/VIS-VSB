namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cart")]
    public partial class cart
    {
        [Key]
        public int cart_id { get; set; }

        public int quantity { get; set; }

        public int shoe_id { get; set; }

        public virtual payment payment { get; set; }

        public virtual shoe shoe { get; set; }
    }
}
