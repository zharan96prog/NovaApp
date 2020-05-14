namespace WpfClientNovaPoshta.EntityForLogin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Package = new HashSet<Package>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Package { get; set; }
    }
}
