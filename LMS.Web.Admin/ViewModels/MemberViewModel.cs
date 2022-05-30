using LMS.Core.Domain.Issues;
using LMS.Core.Domain.Members;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Admin.ViewModels
{
    public class MemberViewModel
    {
        [DisplayName("读者Id")]
        public int MemberId { get; set; }

        [Required]
        [DisplayName("名")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("姓")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("电话号码")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("读者类型")]
        public MemberType MemberType { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
