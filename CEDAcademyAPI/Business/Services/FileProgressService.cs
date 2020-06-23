using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Business.Services
{
    public class FileProgressService : IFileProgressService
    {
        readonly ApplicationDbContext db;

        public FileProgressService(ApplicationDbContext context)
        {
            db = context;
        }
        public FileProgress GetCurrentTime(int idFile, string idUser)
        {
            var query = from st in db.Progresses
                        where st.FileId == idFile && st.UserId == idUser
                        select st.CurrentTime;

            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public FileProgress FileTrack()
        {
            var query = from st in db.FileProgresses
                        select new
                        {
                            //st.ApplicationUser.Email,
                            st.File.FileTitle,
                            st.Pourcentage
                        };
            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public IHttpActionResult VideoUserTrack()

        {
            var query = (from f in db.Files
                         join pr in db.FileProgresses on f.FileID equals pr.FileId
                       into Pro
                         from pr in Pro.DefaultIfEmpty()
                         group f by f into grouped
                         where (grouped.Key.FileName.EndsWith(".mp4"))
                         let totalUsers = grouped.Key.FileProgress.Count()
                         orderby (totalUsers) descending
                         select new
                         {
                             FileName = grouped.Key.FileTitle,
                             NumberOfUsers = totalUsers,
                         }).ToList();


            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public IHttpActionResult GetPourcentageOfProgress(int idFile, string idUser)
        {
            var query = from st in db.FileProgresses
                        where st.FileId == idFile && st.UserId == idUser
                        select st.Pourcentage;
            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public int ProgressNumber()
        {
            var query = (from st in db.FileProgresses
                         group st by 1 into g
                         select new
                         {
                           S = g.Count()
                         }).ToList();
            if (query.Count() == 0)
            {
                return 0;
            }
            else
            {
                var x = Int32.Parse(query[0].ToString().Substring(6, 1));
                return x;
            }

        }
    }
}
