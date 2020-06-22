using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IFileProgressRepository<FileProgress> where FileProgress : class
    {
        void PostProgress(FileProgress progress, string id);
        FileProgress ProgressByUserID(string userId);
        void PutProgress(FileProgress p);
        FileProgress GetProgress(string id);
    }
}
