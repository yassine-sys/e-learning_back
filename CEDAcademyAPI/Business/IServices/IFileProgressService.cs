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
        FileProgress GetCurrentTime(int idFile, string idUser);
        FileProgress FileTrack();
        IHttpActionResult VideoUserTrack();
        IHttpActionResult GetPourcentageOfProgress(int idFile, string idUser);
        int ProgressNumber();
    }
}
