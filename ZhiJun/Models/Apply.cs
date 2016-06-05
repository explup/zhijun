namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apply")]
    public partial class Apply
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "请输入姓名")]
        [StringLength(50, ErrorMessage = "不能超过50字符")]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请选择性别")]
        [StringLength(10, ErrorMessage = "不能超过10字符")]
        [Display(Name = "性别")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "请选择出生日期")]
        [Column(TypeName = "date")]
        [Display(Name = "生日")]
        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "请输入地址")]
        [StringLength(300, ErrorMessage = "不能超过300字符")]
        [Display(Name ="地址")]
        public string Address { get; set; }

        [Required(ErrorMessage = "请输入电话")]
        [StringLength(50, ErrorMessage = "不能超过50字符")]
        [Display(Name = "电话")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "请输入邮箱")]
        [StringLength(50, ErrorMessage = "不能超过50字符")]
        [Display(Name = "邮件")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "请输入申请学校")]
        [StringLength(100, ErrorMessage = "不能超过100字符")]
        [Display(Name = "申请学校")]
        public string UniverstiyName { get; set; }

        [Required(ErrorMessage = "请输入申请专业")]
        [StringLength(100, ErrorMessage = "不能超过100字符")]
        [Display(Name = "申请专业")]
        public string ProgrammeName { get; set; }
    }
}
