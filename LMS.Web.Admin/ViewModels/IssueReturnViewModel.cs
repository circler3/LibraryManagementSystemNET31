using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Web.Admin.ViewModels
{
    public class IssueReturnViewModel
    {
        public int MemberId { get; set; }
        public int BookId { get; set; }

        [DisplayName("书名")]
        public string BookTitle { get; set; }

        [DisplayName("读者姓名")]
        public string MemberName { get; set; }

        [DisplayName("读者电话")]
        public string MemberPhone { get; set; }

        [DisplayName("借阅时间")]
        public DateTime IssueDate { get; set; }

        [DisplayName("归还时间")]
        public DateTime ExpireDate { get; set; }
    }
}
