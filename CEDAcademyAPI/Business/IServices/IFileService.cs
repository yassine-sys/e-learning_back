using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IFileService : IServiceBase<File>
    {
        void UploadFilePDF();
        byte[] GetPdfFile(int id);
        void UploadFile();
        IEnumerable<string> GetVideoFileName(int FileId);

    }
}
