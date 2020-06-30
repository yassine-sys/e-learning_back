using Business.Services;
using Entities.Models;
using System.Collections.Generic;

namespace Business.IServices
{
    public interface IFileProgressService : IServiceBase<FileProgress>
    {
        IEnumerable<float> GetCurrentTime(int idFile, string idUser);
        IEnumerable<FileProgress> GetFileProgresses();
        void GetFilesViewsCount();
        IEnumerable<float> GetPourcentageOfProgress(int idFile, string idUser);
        int GetProgressNumber();
        IEnumerable<FileProgress> GetFileProgressByUserId(string UserId);
    }
}
