using CMS.Models.A1_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public static class UserDataProvider
    {
        private static DataTable UserData = new DataTable("UserDataDt");

        static UserDataProvider()
        {
            UserData.Columns.Add("UserID", typeof(string));
            UserData.Columns.Add("Name", typeof(string));
            UserData.Columns.Add("Age", typeof(int));
            UserData.Columns.Add("Password", typeof(string));
            UserData.Columns.Add("Pet_Name", typeof(string));
            UserData.Columns.Add("Gender", typeof(string));
            UserData.Columns.Add("Sem_ID", typeof(int));
            UserData.Columns.Add("Dept_ID", typeof(int));
            UserData.Columns.Add("Role", typeof(string));
            UserData.Columns.Add("UserPKID", typeof(int));

            UserData.Rows.Add(new Object[] { "admin01", "Abhishek Sahu", 22, "AdminPass01@", "Sakti", "M", 100, 100, "A", 100000 });
            UserData.Rows.Add(new Object[] { "admin02", "Abhishek Sahu2", 222, "AdminPass01@2", "Sakti2", "F", 100, 100, "S", 100001 });
        }

        public static DataTable GetDataTable_UserData()
        {
            return UserData;
        }
        public static DataTable GetDataTable_UserData(string Role)
        {
            DataTable UserDataVar = GetDataTable_UserData();
            DataTable FilteredUserDataVar = UserDataVar.Clone();

            foreach (DataRow dr in UserDataVar.Rows)
            {
                if (dr["Role"].ToString() == Role)
                {
                    FilteredUserDataVar = UserDataVar.Clone();
                    FilteredUserDataVar.ImportRow(dr);
                    return FilteredUserDataVar;
                }
                else
                {
                    FilteredUserDataVar = null;
                }
            }
            return FilteredUserDataVar;
        }

        public static DataTable Get_UserRow_ById(string id)
        {
            DataTable UserDataVar = GetDataTable_UserData();
            DataTable FilteredUserDataVar = UserDataVar.Clone();

            foreach (DataRow dr in UserDataVar.Rows)
            {
                if (dr["UserID"].ToString() == id)
                {
                    FilteredUserDataVar = UserDataVar.Clone();
                    FilteredUserDataVar.ImportRow(dr);
                    return FilteredUserDataVar;
                }
                else
                {
                    FilteredUserDataVar = null;
                }
            }
            return FilteredUserDataVar;
        }
        public static int Get_Latest_UserPKID()
        {
            DataTable UserDataVar = GetDataTable_UserData();
            int Latest_UserPKID = -1;
            foreach (DataRow dr in UserDataVar.Rows)
            {
                Latest_UserPKID = (int)dr["UserPKID"];
            }
            return Latest_UserPKID;
        }
        public static void Add_UserRow(UserDetail userDetail)
        {
            int Latest_UserPKID = Get_Latest_UserPKID();
            try
            {
                DataRow dr = UserData.NewRow();

                dr[0] = userDetail.UserId;
                dr[1] = userDetail.Name;
                dr[2] = userDetail.Age;
                dr[3] = userDetail.Password;
                dr[4] = userDetail.PetName;
                dr[5] = userDetail.Gender;
                dr[6] = userDetail.SemId;
                dr[7] = userDetail.DeptId;
                dr[8] = userDetail.Role;
                dr[9] = Latest_UserPKID + 1;

                UserData.Rows.Add(dr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }
        public static void Update_UserRow(string hiddenuserid,string password)
        {
            foreach (DataRow dr in UserData.Rows)
            {
                if(dr["UserId"].ToString()==hiddenuserid)
                {
                    dr["Password"] = password;
                }
            }
        }
        public static void Delete_UserRow(string id)
        {
            int Latest_UserPKID = Get_Latest_UserPKID();
            try
            {
                foreach (DataRow dr in UserData.Rows)
                {
                    if (dr["UserId"].ToString() == id)
                    {
                        dr.Delete();
                    }
                }
                UserData.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}
