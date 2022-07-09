using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//
using CMS.Models.A1_DB;
using CMS.Constants;

namespace CMS.Controllers
{
    //[Authorize(Roles = RoleCategoryAssign.Admin)]
    [Authorize(Roles = "A")]
    public class studentlistController : Controller
    {
        private readonly CMS_DBContext _context;

        public studentlistController(CMS_DBContext context)
        {
           this._context = context;
           var Student_List = _context.UserDetails.Where(m => m.Role != "A");
        }

        public async Task<IActionResult> Index()
        {
            //var Student_List = _context.UserDetails.Where(m => m.Role != "A").Select(u => new { u.Name, u.Dept.DeptCategoryName, u.Sem.SemCategoryName });
            //return View(await Student_List.ToListAsync());
            var Student_List = _context.UserDetails.Include(u => u.Dept).Include(u => u.Sem).Where(m=>m.Role!="A");
            return View(await Student_List.ToListAsync());
        }
        // GET: UserDetails/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                var Student_Row = _context.UserDetails.Where(d => d.UserPkid == id).First();
                _context.UserDetails.Remove(Student_Row);
                _context.SaveChanges();
                TempData["Result_Student_Delete"] = "Sucess_Database_CURD_Student_Row";
                return RedirectToAction("Index", "studentlist");
            }
            catch
            {
                TempData["Result_Student_Delete"] = "Error_Database_CURD_Student_Row";
                return RedirectToAction("Index", "studentlist");
                //return NotFound();
            }
        }
    }
}