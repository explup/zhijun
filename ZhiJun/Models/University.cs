namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;
    public partial class University
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public University()
        {
            Institutes = new HashSet<Institute>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name ="名字")]
        public string Name { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name = "简介")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "类型")]
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Institute> Institutes { get; set; }
    }
}
