using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace asd.Interface
{
    public interface IFileUpload
    {
        Task<int> UploadFile(List<IFormFile> files);
    }

}
