namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Institute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Institute()
        {
            Programmes = new HashSet<Programme>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "系名字")]
        public string Name { get; set; }
        [Display(Name = "大学")]
        public int University_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programme> Programmes { get; set; }

        public virtual University University { get; set; }
    }
}
