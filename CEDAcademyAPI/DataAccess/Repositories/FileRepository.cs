using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class FileRepository<File> : IFileRepository<File> where File : class
    {
        readonly ApplicationDbContext db;
       
        public FileRepository(ApplicationDbContext context)
        {
            db = context;
        }
        public IEnumerable<File> GetFiles()
        {
            var files = db.Files.ToList();
            return files;
        }
        
        public File GetFile(int FileId)
        {
            return db.Files.Find(FileId);            
        }
        public File GetVideoFile(int FileId)
        {

            File file = db.Files.Find(FileId);
          
            return file.FileName;
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
