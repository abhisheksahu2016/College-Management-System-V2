using CMS.Models.A1_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public static class CourseDataProvider
    {
        private static DataTable CourseData = new DataTable("CourseDataDt");

        static CourseDataProvider()
        {
            CourseData.Columns.Add("Sem_ID", typeof(int));
            CourseData.Columns.Add("Dept_ID", typeof(int));
            CourseData.Columns.Add("Course_ID", typeof(string));
            CourseData.Columns.Add("Course_Name", typeof(string));

            

            CourseData.Rows.Add(new Object[] { 100, 100,"CS101","Mathematics-1"});
            CourseData.Rows.Add(new Object[] { 100, 100,"CS102","Basic Electrical and Electronics" });
            CourseData.Rows.Add(new Object[] { 100, 100, "CS103", "Engineering graphics" });
            CourseData.Rows.Add(new Object[] { 100, 100, "IT101", "Mathematics-1" });
            CourseData.Rows.Add(new Object[] { 100, 100, "IT102", "Basic Electrical and Electronics" });
            CourseData.Rows.Add(new Object[] { 100, 100, "IT103", "Engineering graphics" });

            CourseData.Rows.Add(new Object[] { 101, 100, "CS201", "Engineering Physics" });
            CourseData.Rows.Add(new Object[] { 101, 100, "CS202", "Basic Mechanical Engineering" });
            CourseData.Rows.Add(new Object[] { 101, 100, "CS203", "Basic Computer Engineering" });
            CourseData.Rows.Add(new Object[] { 101, 101, "IT201", "Engineering Physics" });
            CourseData.Rows.Add(new Object[] { 101, 101, "IT202", "Basic Mechanical Engineering" });
            CourseData.Rows.Add(new Object[] { 101, 101, "IT203", "Basic Computer Engineering" });

            CourseData.Rows.Add(new Object[] { 102, 100, "CS301", "Mathematics-3" });
            CourseData.Rows.Add(new Object[] { 102, 100, "CS302", "Electronic Devices and Circuits" });
            CourseData.Rows.Add(new Object[] { 102, 100, "CS303", "Digital Circuits and Design" });
            CourseData.Rows.Add(new Object[] { 102, 101, "IT301", "Mathematics-3" });
            CourseData.Rows.Add(new Object[] { 102, 101, "IT302", "Digital Circuits and Systems" });
            CourseData.Rows.Add(new Object[] { 102, 101, "IT303", "Object Oriented Programming" });
        }

        public static DataTable GetDataTable_CourseData()
        {
            return CourseData;
        }
        public static DataTable GetDataTable_CourseData(string deptname,string semname)
        {
            string dept_id = DeptDataProvider.Get_DeptId(deptname).ToString();
            string sem_id = SemDataProvider.Get_SemId(semname).ToString(); ;

            DataTable CourseDataVar = GetDataTable_CourseData();
            DataTable FilteredCourseDataVar = CourseDataVar.Clone();

            foreach (DataRow dr in CourseDataVar.Rows)
            {
                if (dr["Dept_ID"].ToString() == dept_id & dr["Sem_ID"].ToString() == sem_id)
                {
                    FilteredCourseDataVar = CourseDataVar.Clone();
                    FilteredCourseDataVar.ImportRow(dr);
                }
            }
            return FilteredCourseDataVar;
        }     
    }
}
