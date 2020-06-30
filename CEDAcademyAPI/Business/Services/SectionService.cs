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
        private ISectionRepository repo;

        public SectionService(ISectionRepository repo)
            : base((RepositoryBase<Section>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Section> GetSections()
        {
            throw new NotImplementedException();
        }
        public Section GetSectionById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddSection(Section s)
        {

        }
        public void UpdateSection(Section s)
        {

        }
        public void DeleteSection(Section s)
        {

        }
        public IEnumerable<Section> GetSectionbyChapterId(int ChapterId)
        {
            return repo.GetAll().Where(x => x.ChapterID == ChapterId);
        }
    }
}
