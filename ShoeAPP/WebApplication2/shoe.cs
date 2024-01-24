namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shoe")]
    public partial class shoe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shoe()
        {
            carts = new HashSet<cart>();
        }

        [Key]
        public int shoe_id { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public int size { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        public int price { get; set; }

        public int customer_id { get; set; }

        public int brand_id { get; set; }

        public int supplier_id { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual brand brand { get; set; }
        public virtual ICollection<cart> carts { get; set; }

        public virtual customer customer { get; set; }

        public virtual supplier supplier { get; set; }
    }
}
