namespace ZhiJun.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "请输入消息")]
        [StringLength(200, ErrorMessage = "不能超过200字符")]
        [Display(Name = "消息")]
        public string MessageBody { get; set; }

        [Required(ErrorMessage = "请输入邮件")]
        [StringLength(50,ErrorMessage ="不能超过50字符")]
        [Display(Name = "邮件")]
        public string SenderEmail { get; set; }

        [Required(ErrorMessage = "请输入姓名")]
        [StringLength(50, ErrorMessage = "不能超过50字符")]
        [Display(Name = "姓名")]
        public string SenderName { get; set; }

        [Display(Name = "发送时间")]
        public DateTime SenderDate { get; set; }

        [Display(Name = "处理情况")]
        [StringLength(50, ErrorMessage = "不能超过50字符")]
        public string Processed { get; set; }
    }
}
