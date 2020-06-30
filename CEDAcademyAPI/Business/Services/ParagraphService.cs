﻿using Business.IServices;
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
    public class ParagraphService : ServiceBase<Paragraph>, IParagraphService
    {
        private IParagraphRepository repo;

        public ParagraphService(IParagraphRepository repo)
            : base((RepositoryBase<Paragraph>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Paragraph> GetParagraphs()
        {
            throw new NotImplementedException();
        }
        public Paragraph GetParagraphById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddParagraph(Paragraph p)
        {

        }
        public void UpdateParagraph(Paragraph p)
        {

        }
        public void DeleteParagraph(Paragraph Paragraph)
        {

        }
        public IEnumerable<Paragraph> GetParagraphbySectionID(int SectionId)
        {
            return repo.GetAll().Where(x => x.SectionID == SectionId);
        }

    }
}
