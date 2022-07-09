using System;
using System.Collections.Generic;

using CMS.Models.A1_DB;

namespace CMS.Models.B1_View
{
    public partial class SearchView
    {
        public IEnumerable<DeptCategoryList> DeptCategoryList_Var { get; set; }
        public IEnumerable<SemCategoryList> SemCategoryList_Var { get; set; }
        public IEnumerable<CourseList> CourseList_Var { get; set; }
        public CourseDetail CourseDetail_Var { get; set; }
    }
    public partial class CourseDetail
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }

}
