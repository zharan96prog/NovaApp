namespace WpfClientNovaPoshta.EntityForLogin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Package")]
    public partial class Package
    {
        public int ID { get; set; }

        [Required]
        [StringLength(16)]
        public string Number { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string Department { get; set; }

        [Required]
        [StringLength(100)]
        public string NameDest { get; set; }

        public int Payer { get; set; }

        public int? Remittance { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int? ID_User { get; set; }

        public virtual User User { get; set; }
    }
}
