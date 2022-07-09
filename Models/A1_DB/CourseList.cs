using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models.A1_DB
{
    public partial class CourseList
    {
        public int SemId { get; set; }
        public int DeptId { get; set; }
        [Key]
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual DeptCategoryList Dept { get; set; }
        public virtual SemCategoryList Sem { get; set; }
    }
}
