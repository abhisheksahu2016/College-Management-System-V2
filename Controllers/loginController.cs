using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
//
using CMS.Constants;
using CMS.Services;
using CMS.Validator;
using CMS.Models.A1_DB;
using CMS.Models.B1_View;

namespace CMS.Controllers
{
    public class loginController : Controller
    {
        private readonly CMS_DBContext _context;
        String View_userid="";

        public loginController(CMS_DBContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login/*Index*/(string userid, string password)
        {
            FormValidator_Login FormValidator_Var = new FormValidator_Login();
            List<string> FormValidation_Res = FormValidator_Var.FormValidate(userid,password);
            if (FormValidation_Res.Count==0)
            {
                var userDetail = _context.UserDetails.Where(m => m.UserId == userid).FirstOrDefault(); // (m => m.UserId == userid & m.PetName == petname);
                if(userDetail==null)
                {
                    TempData["Error_login_Login"] = "user name and pass word is incorrect";
                    return RedirectToAction("Index", "login");
                }
                else if (userDetail != null & userDetail.Password == password)
                {
                    var userClaims = new List<Claim>();

                    if (userDetail.Role == "A")
                    {
                        TempData["UserRoleAfterLogin"] = "Admin";
                        ViewData["UserRoleAfterLogin"] = "Admin";

                        userClaims = new List<Claim>()
                        {
                            new Claim("UserId", userDetail.UserId),
                            new Claim(ClaimTypes.Name, userDetail.Name),
                            new Claim(ClaimTypes.Role, "A")
                        };

                    }
                    else
                    {
                        TempData["UserRoleAfterLogin"] = "Student";
                        ViewData["UserRoleAfterLogin"] = "Student";

                        userClaims = new List<Claim>()
                        {
                            new Claim("UserId", userDetail.UserId),
                            new Claim(ClaimTypes.Name, userDetail.Name),
                            new Claim(ClaimTypes.Role, "S")
                        };
                    }
                    HttpContext.Session.SetString("userid", userid);

                    AuthorizeByRoleAttribute AuthorizeByRoleAttribute_Var = new AuthorizeByRoleAttribute();
                    string[] RoleList = { "Admin", "Student" };
                    AuthorizeByRoleAttribute_Var.SetAuthorizeAttribute(RoleList);

                    var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });
                    HttpContext.SignInAsync(userPrincipal);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Error_login_Login"] = "user name and pass word is incorrect";
                    return RedirectToAction("Index", "login");
                }
            }
            else
            {
                string NewLineString = "";
                foreach(var i in FormValidation_Res)
                {
                    if (i !="")
                        NewLineString = NewLineString + i;
                }
                TempData["Error_login_Login"] = NewLineString;
                return RedirectToAction("Index", "login");
            }
        }
        [HttpGet]
        public IActionResult registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> registration(string FormUserName, string FormAge, string FormPassword, string FormPetName, string FormGender,string FormSemId, string FormDeptId, string FormUserId)
        {
            FormValidator_Registration FormValidator_Var = new FormValidator_Registration();
            List<string> FormValidation_Res = FormValidator_Var.FormValidate(FormUserName, FormAge, FormPassword, FormPetName, FormGender, FormSemId, FormDeptId, FormUserId);
            if (FormValidation_Res.Count == 0)
            {
                var userDetail2 = _context.UserDetails.Where(m => m.UserId == FormUserId).FirstOrDefault(); // (m => m.UserId == userid & m.PetName == petname);
                if (userDetail2==null)
                {
                    UserDetail UserDetail_Var = new UserDetail
                    {
                        UserId = FormUserId,
                        Name = FormUserName,
                        Age = FormAge,
                        Password = FormPassword,
                        PetName = FormPetName,
                        Gender = FormUserName == "Male" ? "M" : "F",
                        DeptId = Convert.ToInt32(FormDeptId),
                        SemId = Convert.ToInt32(FormSemId),
                        Role = "S",
                    };
                    _context.Add<UserDetail>(UserDetail_Var);
                    await _context.SaveChangesAsync();
                    TempData["Result_login_Login"] = "New User Registration Sucess-Now you can Login";
                    return RedirectToAction("Index", "login");
                }
                else
                {
                    TempData["Error_login_Registration"] = "User already exists";
                    return RedirectToAction("Registration", "login");
                }
            }
            else
            {
                string NewLineString = "";
                foreach (var i in FormValidation_Res)
                {
                    if (i != "")
                        NewLineString = NewLineString + i;
                }
                TempData["Error_login_Registration"] = NewLineString;
                return RedirectToAction("Registration", "login");
            }
        }

        [HttpGet]
        public IActionResult forgotpassword()
        {
            ForgotpasswordView ForgotpasswordViewVar = new ForgotpasswordView();
            return View(ForgotpasswordViewVar);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult forgotpassword(ForgotpasswordView fpv)
        {
            string userid;
            string petname;

            if (fpv.UserId!=null || fpv.PetName!=null)
            {
                userid = fpv.UserId;
                petname = fpv.PetName;
            }
            else
            {
                userid = "";
                petname = "";
            }
            FormValidator_ForgotPassword FormValidator_Var = new FormValidator_ForgotPassword();
            List<string> FormValidation_Res = FormValidator_Var.FormValidate(userid, petname);

            if (FormValidation_Res.Count == 0)
            {
                var userDetail3 = _context.UserDetails.Where(m => m.UserId == userid).Single(); // (m => m.UserId == userid & m.PetName == petname);
                if (userDetail3 != null & userDetail3.PetName==petname)
                {
                    View_userid = userid;
                    TempData["Result_login_forgotpassword"] = "Sucess Detail";
                    TempData["UserIdValAfterValidate"] = userid;
                    return View(fpv);
                }
                else
                {
                    TempData["Error_login_forgotpassword"] = "User Id/Security answer is invalid";
                    return View(fpv);
                }
            }
            else
            {
                string NewLineString = "";
                foreach (var i in FormValidation_Res)
                {
                    if (i != "")
                        NewLineString = NewLineString + i;
                }
                TempData["Error_login_forgotpassword"] = NewLineString;
                return RedirectToAction("forgotpassword", "login");
            }
        }

        [HttpPost]
        public async Task<IActionResult> forgotpassword2(ForgotpasswordView fpv)
        {
            string password = "";
            string password2 = "";
            string hiddenuserid = "";

            if (fpv.UserId != null || fpv.PetName != null)
            {
                password = fpv.Password;
                password2 = fpv.ConfirmPassword;
                hiddenuserid = fpv.UserId;
            }

            TempData["Result_login_forgotpassword"] = "Success Detail";
            FormValidator_ForgotPassword2 FormValidator_Var = new FormValidator_ForgotPassword2();
            List<string> FormValidation_Res = FormValidator_Var.FormValidate(password, password2);
            if (FormValidation_Res.Count == 0)
            {
                var userDetail3 = _context.UserDetails.Where(m => m.UserId == hiddenuserid).Single(); // (m => m.UserId == userid & m.PetName == petname);

                userDetail3.Password = password;
                _context.Update(userDetail3);
                await _context.SaveChangesAsync();
                TempData["Result_login_Login"] = "Password successfully changed";
                return RedirectToAction("Index", "login");
            }
            else
            {
                string NewLineString = "";
                foreach (var i in FormValidation_Res)
                {
                    if (i != "")
                        NewLineString = NewLineString + i;
                }
                TempData["UserIdValAfterValidate"] = hiddenuserid;
                TempData["Error_login_forgotpassword"] = NewLineString;
                //return RedirectToAction("forgotpassword", "login", fpv);
                return View("forgotpassword", fpv);
            }
        }

        [HttpGet]
        public  IActionResult Logout()
        {
            HttpContext.Session.Remove("userid");
            HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}