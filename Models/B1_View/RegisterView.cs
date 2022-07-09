using System;
using System.Collections.Generic;

using CMS.Models.A1_DB;

namespace CMS.Models.B1_View
{
    public partial class RegisterView
    {
        public IEnumerable<DeptCategoryList> DeptCategoryList_Var { get; set; }
        public IEnumerable<SemCategoryList> SemCategoryList_Var { get; set; }
        public UserDetail UserDetail_Var { get; set; }
    }
}
