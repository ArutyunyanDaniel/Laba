namespace Laba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transport")]
    public partial class Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transport()
        {
            Drivers = new HashSet<Driver>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        public string Number { get; set; }

        public int ID_Type { get; set; }

        public int ID_Dimension { get; set; }

        public int ID_Weight { get; set; }

        public int ID_Brand { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Dimension Dimension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Drivers { get; set; }

        public virtual Type Type { get; set; }

        public virtual Weight Weight { get; set; }
    }
}
