using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeServiceController : Controller
    {
        
        public ActionResult Registration()
        {
            DesignationListDataContext _designation = new DesignationListDataContext();
            ViewBag.deg = new SelectList(_designation.GET_Degeneration(), "Pk_DegId", "Degeneration");
            return View();
        }

        [HttpPost]
        public void EmployeeRegistrationSave(FormCollection formdata )
        {

        
            EmployeeRegistrationDataContext _db = new EmployeeRegistrationDataContext();
            EMP_Employee_Mst emp = new EMP_Employee_Mst();
            emp.Fk_DegId= Convert.ToInt32(formdata["GET_DegenerationResult"]);
            emp.FullName= formdata["txt_Username"];
            emp.Email = formdata["txt_email"];
            emp.LocalAddress = formdata["txt_localAddress"];
            _db.EMP_Employee_Msts.InsertOnSubmit(emp);
            _db.SubmitChanges();

        }
    }
}