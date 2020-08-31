using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using asd.Interface;
using Microsoft.AspNetCore.Http;

namespace asd
{
    public class FileUploadService : IFileUpload
    {
        public async Task<int> UploadFile(List<IFormFile> files)
        {
            int count = files.ToList().Count();
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in Upload folder

                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", formFile.FileName);
                    filePaths.Add(filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return count;
        }
    }
}
