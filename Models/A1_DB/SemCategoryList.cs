using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models.A1_DB
{
    public partial class SemCategoryList
    {
        public SemCategoryList()
        {
            CourseLists = new HashSet<CourseList>();
            UserDetails = new HashSet<UserDetail>();
        }

        public string SemCategoryName { get; set; }
        [Key]

        public int SemCategoryId { get; set; }

        public virtual ICollection<CourseList> CourseLists { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
