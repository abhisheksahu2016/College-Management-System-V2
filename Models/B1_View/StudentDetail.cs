using System;
using System.Collections.Generic;

namespace CMS.Models.B1_View
{
    public partial class StudentDetailView
    {
        public IEnumerable<StudentDetail> StudentList_Var { get; set; }
    }
    public partial class StudentDetail
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Sem { get; set; }
        public string UserPkid { get; set; }
    }
}
