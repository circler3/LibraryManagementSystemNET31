using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Admin.ViewModels
{
    public class SubjectViewModel
    {
        [DisplayName("主题Id")]
        public int SubjectId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<BookViewModel> Books { get; set; }
    }
}
