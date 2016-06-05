namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Programme
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "专业名字")]
        public string Name { get; set; }

        [Display(Name = "详细描述")]
        public string Detail { get; set; }

        public int StudyOption_Id { get; set; }

        [Display(Name = "学制")]
        public double Lengh { get; set; }

        [Display(Name = "学习地点")]
        public string Location { get; set; }

        [Display(Name = "条件")]
        public string Requirement { get; set; }

        [Display(Name = "层次")]
        public int Level_Id { get; set; }

        [Display(Name = "序号")]
        public int ClientNumber { get; set; }

        [Display(Name = "科类")]
        public int University_Id { get; set; }

        [Display(Name = "费用")]
        public double? Fee { get; set; }

 
        [Display(Name = "考试形式")]
        public string EaxmStyle { get; set; }

  
        [Display(Name = "招生范围")]
        public string Range { get; set; }

        [Display(Name = "科类")]
        public int Institute_Id { get; set; }

        public virtual Institute Institute { get; set; }

        public virtual University University { get; set; }

        public virtual Level Level { get; set; }

        public virtual StudyOption StudyOption { get; set; }
    }
}
