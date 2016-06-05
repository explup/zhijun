namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;
    public partial class News
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "题目")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "简述")]
        public string Abstract { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name = "文章")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "作者")]
        public string Author { get; set; }

        [Display(Name = "创建时间")]
        public DateTime CreatedDate { get; set; }

        public int Category_Id { get; set; }

        public virtual Category Category { get; set; }
    }
}
