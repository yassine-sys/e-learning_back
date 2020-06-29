using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace Business.Services
{
    public class FileProgressService : IFileProgressService

    {
        private IFileProgressRepository repo;

        public FileProgressService(IFileProgressRepository repo)
        {
            this.repo = repo;
        }
        public IQueryable<float> GetCurrentTime(int idFile, string idUser)
        {
            var query = from st in db.FileProgresses
                        where st.FileId == idFile && st.CreatedBy == idUser
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
        public IQueryable<FileProgress> FileTrack()
        {
            return this.db.FileProgresses.AsQueryable();
        }

        [HttpGet]
        public IHttpActionResult GetFilesViewsCount()
        {
            //var filesProgresses = this.db.FileProgresses;

            //var viewedFilesIds = filesProgresses
            //    .Select(x => x.Id)
            //    .Distinct()
            //    .ToList();

            //var viewedFiles = this.db.Files
            //    .Where(x => x.FileName.EndsWith(".mp4")
            //        && viewedFilesIds.Contains(x.Id))
            //    .GroupBy(x => x.Id, x => x.);
            
            var query = (from f in db.Files
                         join pr in db.FileProgresses on f.Id equals pr.FileId
                         into Pro
                         from pr in Pro.DefaultIfEmpty()
                         group f by f into grouped
                         where (grouped.Key.FileName.EndsWith(".mp4"))
                         let totalUsers = grouped.Key.Progress.Count()
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
                return Ok(query);
            }
        }
        public IHttpActionResult GetPourcentageOfProgress(int idFile, string idUser)
        {
            var query = from st in db.FileProgresses
                        where st.FileId == idFile && st.CreatedBy == idUser
                        select st.Pourcentage;
            if (query == null)
            {
                return null;
            }
            else
            {
                return Ok(query);
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
