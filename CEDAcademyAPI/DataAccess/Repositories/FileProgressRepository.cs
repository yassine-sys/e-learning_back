using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;

namespace DataAccess.Repositories
{
    public class FileProgressRepository<FileProgress> : IFileProgressRepository<FileProgress> where FileProgress : class
    {
        readonly ApplicationDbContext db;

        public FileProgressRepository(ApplicationDbContext context)
        {
            db = context;
        }
        public void PostProgress(FileProgress progress, string id)
        {
            db.FileProgresses.Add(progress);
            db.SaveChanges();
        }
        public FileProgress ProgressByUserID(string userId)

        {
            var query = from st in db.FileProgresses
                        where st.UserId == userId
                        select st;            
            return query;
        }
        public void PutProgress(FileProgress p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
        }
        public FileProgress GetProgress(string id)
        {


            FileProgress p =db.FileProgresses.Find(Int32.Parse(id));
            if (p == null)
            {
                return null;
            }

            return p;
        }

    }
}
