using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models.A1_DB
{
    public partial class DeptCategoryList
    {
        public DeptCategoryList()
        {
            CourseLists = new HashSet<CourseList>();
            UserDetails = new HashSet<UserDetail>();
        }

        public string DeptCategoryName { get; set; }
        [Key]

        public int DeptCategoryId { get; set; }

        public virtual ICollection<CourseList> CourseLists { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
