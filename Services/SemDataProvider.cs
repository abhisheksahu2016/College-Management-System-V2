using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public static class SemDataProvider
    {
        private readonly static DataTable SemData = new DataTable("SemDataDt");

        static SemDataProvider()
        {
            SemData.Columns.Add("SemCategory_Name", typeof(string));
            SemData.Columns.Add("SemCategory_ID", typeof(int));

            SemData.Rows.Add(new Object[]{"Semester - 01",100});
            SemData.Rows.Add(new Object[] { "Semester - 02",101 });
            SemData.Rows.Add(new Object[] { "Semester - 03",102 });
        }

        public static DataTable GetDataTable_SemData()
        {
            return SemData;
        }
        public static List<string> GetAll_SemName()
        {
            DataTable SemDataVar = GetDataTable_SemData();
            List<string> UniqueSemNameList = new List<string>();
            foreach (DataRow row in SemDataVar.Rows)
            {
                if (!UniqueSemNameList.Contains((string)row["SemCategory_Name"])) UniqueSemNameList.Add((string)row["SemCategory_Name"]);
            }
            return UniqueSemNameList;
        }
        public static string Get_SemName(string id)
        {
            DataTable SemDataVar = GetDataTable_SemData();
            string SemName = "";
            foreach (DataRow row in SemDataVar.Rows)
            {
                if (row["SemCategory_ID"].ToString() == id)
                {
                    return row["SemCategory_Name"].ToString();
                }
            }
            return SemName;
        }
        public static int Get_SemId(string name)
        {
            DataTable SemDataVar = GetDataTable_SemData();
            int SemId = -1;
            foreach (DataRow row in SemDataVar.Rows)
            {
                if (row["SemCategory_Name"].ToString() == name)

                {
                    return Convert.ToInt32(row["SemCategory_Id"].ToString());
                }
            }
            return SemId;
        }
    }
}
