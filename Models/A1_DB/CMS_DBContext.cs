using System;
using System.Collections.Generic;
using System.Linq;
using CMS.Models.A1_DB;
using Microsoft.EntityFrameworkCore;

namespace CMS.Models.A1_DB
{
    public class CMS_DBContext : DbContext
    {
        public virtual DbSet<CourseList> CourseLists { get; set; }
        public virtual DbSet<DeptCategoryList> DeptCategoryLists { get; set; }
        public virtual DbSet<SemCategoryList> SemCategoryLists { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        public CMS_DBContext(DbContextOptions<CMS_DBContext> context) : base(context)
        {
            if (!this.DeptCategoryLists.Any())
            {
                this.DeptCategoryLists.Add(new DeptCategoryList { DeptCategoryName = "Computer Science", DeptCategoryId = 100 });
                this.DeptCategoryLists.Add(new DeptCategoryList { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 });
                this.SaveChanges();
            }
            if (!this.SemCategoryLists.Any())
            {
                this.SemCategoryLists.Add(new SemCategoryList { SemCategoryName = "Semester - 01", SemCategoryId = 100 });
                this.SemCategoryLists.Add(new SemCategoryList { SemCategoryName = "Semester - 02", SemCategoryId = 101 });
                this.SemCategoryLists.Add(new SemCategoryList { SemCategoryName = "Semester - 03", SemCategoryId = 102 });
                this.SaveChanges();
            }

            if (!this.CourseLists.Any())
            {
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 01", SemCategoryId = 100 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Mathematics-1", CourseId = "CS101" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 01", SemCategoryId = 100 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Basic Electrical and Electronics", CourseId = "CS102" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 01", SemCategoryId = 100 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Engineering graphics", CourseId = "CS103" });

                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 01", SemCategoryId = 100 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Mathematics-1", CourseId = "IT101" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 01", SemCategoryId = 100 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Basic Electrical and Electronics", CourseId = "IT102" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 01", SemCategoryId = 100 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Engineering graphics", CourseId = "IT103" });

                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 02", SemCategoryId = 101 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Engineering Physics", CourseId = "CS201" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 02", SemCategoryId = 101 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Basic Mechanical Engineering", CourseId = "CS202" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 02", SemCategoryId = 101 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Basic Computer Engineering", CourseId = "CS203" });

                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 02", SemCategoryId = 101 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Engineering Physics", CourseId = "IT201" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 02", SemCategoryId = 101 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Basic Mechanical Engineering", CourseId = "IT202" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 02", SemCategoryId = 101 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Basic Computer Engineering", CourseId = "IT203" });

                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 03", SemCategoryId = 102 }, Dept = new DeptCategoryList() { DeptCategoryName = "Mathematics-3", DeptCategoryId = 100 }, CourseName = "Engineering Physics", CourseId = "CS301" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 03", SemCategoryId = 102 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Electronic Devices and Circuits", CourseId = "CS302" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 03", SemCategoryId = 102 }, Dept = new DeptCategoryList() { DeptCategoryName = "Computer Science", DeptCategoryId = 100 }, CourseName = "Digital Circuits and Design", CourseId = "CS303" });

                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 03", SemCategoryId = 102 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Mathematics-3", CourseId = "IT301" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 03", SemCategoryId = 102 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Digital Circuits and Systems", CourseId = "IT302" });
                this.CourseLists.Add(new CourseList { Sem = new SemCategoryList() { SemCategoryName = "Semester - 03", SemCategoryId = 102 }, Dept = new DeptCategoryList() { DeptCategoryName = "Information and Technology", DeptCategoryId = 101 }, CourseName = "Object Oriented Programming", CourseId = "IT303" });

                this.SaveChanges();
            }
            if (!this.UserDetails.Any())
            {
                this.UserDetails.Add(new UserDetail { UserId = "admin01", Name = "Abhishek Sahu1", Age = "21", Password = "AdminPass01@", PetName = "Aakti", Gender = "M", SemId = 100, DeptId = 100 ,Role="A"});
                this.UserDetails.Add(new UserDetail { UserId = "student01", Name = "Rahul Gandhi", Age = "11", Password = "StudentPass01@", PetName = "Sakti", Gender = "M", SemId = 101, DeptId = 101, Role = "S" });
                this.UserDetails.Add(new UserDetail { UserId = "student02", Name = "Smita Patel", Age = "12", Password = "StudentPass02@", PetName = "Sakti", Gender = "F", SemId = 101, DeptId = 101, Role = "S" });

                this.SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        public CMS_DBContext()
        {
            
        }
    }
}
