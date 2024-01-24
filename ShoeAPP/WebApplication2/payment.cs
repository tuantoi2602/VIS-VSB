namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("payment")]
    public partial class payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cart_id { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        public virtual cart cart { get; set; }
    }
}
