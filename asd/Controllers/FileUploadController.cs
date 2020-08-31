using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using asd.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asd.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IFileUpload _fileUpload;
        public FileUploadController(IFileUpload fileUpload)
        {
            _fileUpload = fileUpload;
        }
        //GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            int filecount = await _fileUpload.UploadFile(files);
            if (filecount > 0)
            {
                return LocalRedirect("/Home/Privacy");
            }
            return LocalRedirect("/Home/Index");

            //long size = files.Sum(f => f.Length);

            //var filePaths = new List<string>();
            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
            //        // full path to file in Upload folder
            //        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", formFile.FileName);
            //        filePaths.Add(filePath);
            //        using (var stream = new FileStream(filePath, FileMode.Create))
            //        {
            //            await formFile.CopyToAsync(stream);
            //        }
            //    }
            //}
            //return Ok(new { count = files.Count, size, filePaths });
        }
    }
}
