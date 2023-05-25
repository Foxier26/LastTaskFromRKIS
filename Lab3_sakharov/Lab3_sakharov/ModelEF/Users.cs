namespace Lab3_sakharov.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        [StringLength(20)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int roleId { get; set; }

        [Required]
        [StringLength(100)]
        public string FIO { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
