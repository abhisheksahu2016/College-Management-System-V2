using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
//
using CMS.Constants;
using CMS.Services;
using CMS.Models.A1_DB;
using CMS.Models.B1_View;

namespace CMS.Controllers
{
    [Authorize(Roles = RoleCategoryAssign.Admin + "," + RoleCategoryAssign.Student)]
    public class coursesearchController : Controller
    {
        private readonly CMS_DBContext _context;

        public coursesearchController(CMS_DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string deptname,string semname)
        {
            //var courseList = await _context.CourseLists.Include(c => c.Dept).Include(c => c.Sem).FirstOrDefaultAsync(m => m.Dept.DeptCategoryName == deptname && m.Sem.SemCategoryName== semname);
            var courseList = new SearchView
            {
                CourseList_Var = _context.CourseLists.Where(m => m.Dept.DeptCategoryName == deptname && m.Sem.SemCategoryName == semname)
            };

            if(courseList == null)
            {
                TempData["Result_coursesearch_search"] = "Negetive";
                //return RedirectToAction("Index", "coursesearch");
            }
            else
            {
                TempData["Result_coursesearch_search"] = "Positive";
                return View("Index", courseList);
            }
            return View(courseList);
        }
    }
}