using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Microsoft.AspNetCore.Authorization;

namespace CMS.Validator
{
    public  class FormValidator_Login
    {        
        public List<string> FormValidate(string userid, string password)
        {
            List<string> Final_Error = new List<string>();
            if(userid!=null & password!=null)
            {   
                // User Id
                Regex r = new Regex("^[a-zA-Z0-9]");
                if (!(r.IsMatch(userid)))
                    Final_Error.Add("user id is not alpha numeric");
                if (!(userid.Length >= 6 & userid.Length <= 10))
                    Final_Error.Add("user id is of invalid length");
                // Password
                //var regexItem = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?==.*[*$@]).+$");
                var regexItem = new Regex("^[a-zA-Z0-9]");
                if(! ( password.Any(char.IsUpper) & password.Any(char.IsLower) & password.Any(char.IsDigit) & password.IndexOfAny("*&#@".ToCharArray())!=-1) )
                //if (!(regexItem.IsMatch(password)))
                    Final_Error.Add("password doesn’t match the criteria");
                if (!(password.Length >= 8 & password.Length <= 16))
                    Final_Error.Add("password is of invalid length");
            }
            else
            {
                if(userid==null & password!=null)
                    Final_Error.Add("user id is Empty");
                if (userid != null & password == null)
                    Final_Error.Add("password is Empty");
                if (userid == null & password == null)
                    Final_Error.Add("user id and password are Empty");
            }
            return Final_Error;
        }
    }
    public class FormValidator_Registration : FormValidator_Login
    {
        public List<string> FormValidate(string FormName, string FormAge, string FormPassword, string FormPetName, string FormGender, string FormSemId, string FormDeptId, string FormUserId)
        {
            List<string> Final_Error_Current = new List<string>();
            //
            List<string> Final_Error_Super = new List<string>();
            Final_Error_Super = this.FormValidate(FormUserId, FormPassword);
            foreach(var i in Final_Error_Super)
            {
                if(i!=null)
                    Final_Error_Current.Add(i);
            }
            //
            if (FormName != null & FormAge != null & FormPetName != null & FormGender != null & FormSemId != null & FormDeptId != null)
            {
                // User Name
                if (!(FormName.Length >= 3 & FormName.Length <= 20))
                    Final_Error_Current.Add("Name must be at least 3 - 20 characters long");
                // Pet Name
                var regexItem = new Regex("^[a-zA-Z]");
                if (!(regexItem.IsMatch(FormPetName)))
                    Final_Error_Current.Add("Allows only alphabets");
                // Age
                regexItem = new Regex("^[0-9]");
                if (!(FormAge.All(char.IsDigit)))
                {
                    if (!(Convert.ToInt32(FormAge) > 999))
                        Final_Error_Current.Add("Only numbers. Max 3 digits");
                }
                else
                {
                    if (!(Convert.ToInt32(FormAge) >= 18 & Convert.ToInt32(FormAge) <= 120))
                        Final_Error_Current.Add("Age should be greater than 18 and less than 120.");
                }
            }
            else
            {
                if(FormName == null | FormAge == null | FormPetName == null | FormGender == null | FormSemId == null | FormDeptId == null)
                    Final_Error_Current.Add("All fields are required. Max allowed number of characters for any field is 30.");
            }
            return Final_Error_Current;
        }
    }
    public class FormValidator_ForgotPassword 
    {
        public List<string> FormValidate(string FormUserId, string FormPetName)
        {
            List<string> Final_Error = new List<string>();
            if (FormUserId != null & FormPetName != null)
            {
                // User Id
                Regex r = new Regex("^[a-zA-Z0-9]");
                if (!(r.IsMatch(FormUserId)))
                    Final_Error.Add("user id is not alpha numeric");
                if (!(FormUserId.Length >= 6 & FormUserId.Length <= 10))
                    Final_Error.Add("user id is of invalid length");
                // PetName
                var regexItem = new Regex("^[a-zA-Z]");
                if (!(regexItem.IsMatch(FormPetName)))
                    Final_Error.Add("Allows only alphabets");
            }
            else
            {
                if (FormUserId == null & FormPetName != null)
                    Final_Error.Add("user id is Empty");
                if (FormUserId != null & FormPetName == null)
                    Final_Error.Add("password is Empty");
                if (FormUserId == null & FormPetName == null)
                    Final_Error.Add("user id and password are Empty");
            }
            return Final_Error;
        }
    }
    public class FormValidator_ForgotPassword2
    {
        public List<string> FormValidate(string password, string confirmpassword)
        {
            List<string> Final_Error = new List<string>();
            if (password != null & confirmpassword != null)
            {
                // Password
                //var regexItem = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?==.*[*$@]).+$");
                var regexItem = new Regex("^[a-zA-Z0-9]");
                if (!(password.Any(char.IsUpper) & password.Any(char.IsLower) & password.Any(char.IsDigit) & password.IndexOfAny("*&#@".ToCharArray()) != -1))
                    //if (!(regexItem.IsMatch(password)))
                    Final_Error.Add("password doesn’t match the criteria");
                if (!(password.Length >= 8 & password.Length <= 16))
                    Final_Error.Add("password is of invalid length");

                // Both
                if (password !=confirmpassword)
                    Final_Error.Add("Password and Confirm Password should be of same Length");
            }
            else
            {
                if (password == null & confirmpassword != null)
                    Final_Error.Add("Password is Mandatory");
                if (password != null & confirmpassword == null)
                    Final_Error.Add("Confirm Password is Mandatory");
                if (password == null & confirmpassword == null)
                    Final_Error.Add("Password and Confirm Password are Empty");
            }
            return Final_Error;
        }
    }

}

