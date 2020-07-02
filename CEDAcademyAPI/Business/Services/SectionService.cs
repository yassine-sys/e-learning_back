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

namespace Business.Services
{
    public class SectionService : ServiceBase<Section>, ISectionService
    {
        private readonly ISectionRepository repo;

        public SectionService(ISectionRepository repo)
            : base((RepositoryBase<Section>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Section> GetSectionbyChapterId(int ChapterId)
        {
            return repo.GetAll().Where(x => x.ChapterID == ChapterId);
        }
    }
}
