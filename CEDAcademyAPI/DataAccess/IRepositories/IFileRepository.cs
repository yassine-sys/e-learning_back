using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IFileRepository<File> where File : class
    {
        IEnumerable<File> GetFiles;
        File GetFile(int FileId);
        File GetVideoFile(int FileId);
        void Save();
    }
}
