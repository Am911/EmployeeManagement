using EmployeeManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class MasterPagesController : Controller
    {
        // GET: MasterPages
        public ActionResult MakeGender()
        {
            GetAllGender();
            return View();
        }

        [HttpPost]
        public ActionResult SaveGender(FormCollection formdata)
        {
            try
            {
                GenderDataContext _gender = new GenderDataContext();
                COMM_GENDER_MST gen = new COMM_GENDER_MST();
                gen.Gender = formdata["txt_gender"];
                gen.IsActive = formdata["IsActive"] != null && formdata["IsActive"].Equals("true,false");
                gen.Alias = Convert.ToChar(formdata["txt_alias"]);
                _gender.COMM_GENDER_MSTs.InsertOnSubmit(gen);
                _gender.SubmitChanges();
                GetAllGender();
                return View("MakeGender");
            }
            catch(Exception ex)
            {
                return View("MakeGender");
            }
        }

        public void GetAllGender()
        {
            GetAllGenderDataContext _genderContext = new GetAllGenderDataContext();
            dynamic genderlist = (from x in _genderContext.Get_Gender() select x).ToList();
            ViewBag.Gender = genderlist;
        }


        public ActionResult JobDesignation()
        {
            return View();
        }
    }
}