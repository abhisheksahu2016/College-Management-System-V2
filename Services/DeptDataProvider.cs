using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public class DeptDataProvider
    {
        private static DataTable DeptData = new DataTable("DeptDataDt");

        static DeptDataProvider()
        {
            DeptData.Columns.Add("DeptCategory_Name", typeof(string));
            DeptData.Columns.Add("DeptCategory_ID", typeof(int));

            DeptData.Rows.Add(new Object[]{"Computer Science",100});
            DeptData.Rows.Add(new Object[] { "Information and Technology",101 });
        }

        public static DataTable GetDataTable_DeptData()
        {
            return DeptData;
        }
        public static List<string> GetAll_DeptName()
        {
            DataTable DeptDataVar = GetDataTable_DeptData();
            List<string> UniqueSemNameList = new List<string>();
            foreach (DataRow row in DeptDataVar.Rows)
            {
                if (!UniqueSemNameList.Contains((string)row["DeptCategory_Name"])) UniqueSemNameList.Add((string)row["DeptCategory_Name"]);
            }
            return UniqueSemNameList;
        }
        public static string Get_DeptName(string id)
        {
            DataTable DeptDataVar = GetDataTable_DeptData();
            string DeptName = "";
            foreach (DataRow row in DeptDataVar.Rows)
            {
                if(row["DeptCategory_ID"].ToString()==id)
                {
                    return row["DeptCategory_Name"].ToString();
                }
            }
            return DeptName;
        }
        public static int Get_DeptId(string name)
        {
            DataTable DeptDataVar = GetDataTable_DeptData();
            int DeptId = -1;
            foreach (DataRow row in DeptDataVar.Rows)
            {
                if (row["DeptCategory_Name"].ToString() == name)

                {
                    return Convert.ToInt32(row["DeptCategory_Id"].ToString());
                }
            }
            return DeptId;
        }
    }
}
