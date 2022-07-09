using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models.A1_DB
{
    public partial class UserDetail
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Password { get; set; }
        public string PetName { get; set; }
        public string Gender { get; set; }
        public int SemId { get; set; }
        public int DeptId { get; set; }
        public string Role { get; set; }
        [Key]

        public int UserPkid { get; set; }

        public virtual DeptCategoryList Dept { get; set; }
        public virtual SemCategoryList Sem { get; set; }
    }
}
