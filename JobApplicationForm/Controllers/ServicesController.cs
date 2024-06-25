using JobApplicationForm.Areas.Identity.Data.DataModel;
using JobApplicationForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobApplicationForm.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(ApplicationViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            BasicDetails basicModel = new BasicDetails()
            {
                Name = model.Name,
                Email = model.Email,
                Address = model.Address,
                PhoneNo = model.PhoneNo,
                Gender = model.Gender,
                RelationshipStatus = model.RelationshipStatus
            };

            int count = 1;
            foreach (var item in model.EducationDetails)
            {
                EducationDetails educationModel = new EducationDetails()
                {
                    EduLevel = count,
                    BoardName = item.BoardName,
                    Percentage = item.Percentage,
                    PassingYear = item.PassingYear
                };
                count++;
            }

            string[] langArr = new string[] { "hindi", "english", "gujarati" };
            string[] knownArr = new string[] { "read", "write", "speak" };
            //Exp remaining
            for(int i=0; i<3; i++)
            {  
                Languages langModel = new Languages();
                if (model.LangName[i] == null)
                {
                    langModel.LangName = langArr[i];
                }
                string langLevel = "";
                for(int j=0; j<3; j++)
                {
                    if (model.LangLevel[i][j] == null)
                    {
                        langLevel += knownArr[i] + ",";
                    }
                }
                if(langLevel != "")
                {
                    langLevel = langLevel.TrimEnd(',');
                }
                Console.WriteLine(langLevel);
                langModel.LangLevel = langLevel;
            }

            string[] techName = new string[] { "php", "mysql", "oracle", "laravel" };


            return RedirectToAction("Index", "Home");
        }
    }
}
