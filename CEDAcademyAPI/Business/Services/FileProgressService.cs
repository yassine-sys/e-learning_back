using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
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
    public class FileProgressService : ServiceBase<FileProgress>, IFileProgressService

    {
        private IFileProgressRepository repo;

        public FileProgressService(IFileProgressRepository repo)
            : base((RepositoryBase<FileProgress>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<float> GetCurrentTime(int idFile, string idUser)
        {
            return repo.GetAll().Where(x => x.FileId == idFile && x.CreatedBy == idUser).Select(x=>x.CurrentTime);          
        }
        public IEnumerable<FileProgress> GetFileProgresses()
        {
            return repo.GetAll().AsQueryable();
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

            repo.GetAll()
                .Where(x => x.File.FileType.TypeName == FileTypeName.mp4)
                .GroupBy(x=>x.File.FileName)
                .Select(x => new {
                    

                });


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
        public IEnumerable<float> GetPourcentageOfProgress(int idFile, string idUser)
        {
            return repo.GetAll().Where(x => x.FileId == idFile && x.CreatedBy == idUser).Select(x => x.Pourcentage);
        }
        public int GetProgressNumber()
        {
            return repo.GetAll().Count();
        }
        public IEnumerable<FileProgress> GetFileProgressByUserId(string UserId)
        {
            return repo.GetAll().Where(x => x.CreatedBy == UserId);
        }
    }
}
