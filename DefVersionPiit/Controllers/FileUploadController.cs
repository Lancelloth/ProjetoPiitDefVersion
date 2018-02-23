using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefVersionPiit.Models;

namespace DefVersionPiit.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult UploadPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase[] files)
        {

            //Ensure model state is valid  
            if (ModelState.IsValid)
            {   //iterating through multiple file collection   
                foreach (HttpPostedFileBase file in files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Session["usuarioLogado"] + Path.GetExtension(file.FileName) ;
                        InputFileName = (InputFileName.Replace(" ", "-").ToUpper());
                        var ServerSavePath = Path.Combine(Server.MapPath("~/Img/") + InputFileName);
                        //Save file to server folder  
                        file.SaveAs(ServerSavePath);
                        //assigning file uploaded status to ViewBag for showing message to user.  
                        ViewBag.UploadStatus = files.Count().ToString() + " Arquivo(s) enviado(s) com sucesso!";

                        
                    }

                }
            }
            return View("UploadPage");
        }

    }
}