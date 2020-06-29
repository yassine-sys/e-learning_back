using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Business.IServices
{
    public interface IFileProgressService
    {
        IQueryable<float> GetCurrentTime(int idFile, string idUser);
        IQueryable<FileProgress> FileTrack();
        IHttpActionResult GetFilesViewsCount();
        IHttpActionResult GetPourcentageOfProgress(int idFile, string idUser);
        int ProgressNumber();
    }
}
