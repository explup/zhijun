namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "事件题目")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "详细描述")]
        public string Detail { get; set; }

        [Display(Name = "起始日期")]
        public DateTime FromDate { get; set; }

        [Display(Name = "结束日期")]
        public DateTime ToDate { get; set; }

        [Required]
        [Display(Name = "地点")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "联系人手机号")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "联系人姓名")]
        public string ContactName { get; set; }
    }
}
