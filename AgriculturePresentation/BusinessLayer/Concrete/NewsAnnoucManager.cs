using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsAnnoucManager : INewsAnnoucService
    {
        private readonly INewsAnnouncDal _newsAnnounc;

        public NewsAnnoucManager(INewsAnnouncDal newsAnnounc)
        {
            _newsAnnounc = newsAnnounc;
        }

        public void Delete(NewsAnnouc t)
        {
            _newsAnnounc.Delete(t);
        }

        public NewsAnnouc GetById(int id)
        {
            return _newsAnnounc.GetById(id);
        }

        public List<NewsAnnouc> GetListAll()
        {
            return _newsAnnounc.GetListAll();
        }

        public void Insert(NewsAnnouc t)
        {
            _newsAnnounc.Insert(t);
        }

        public void NewsAnnoucStatusToFalse(int id)
        {
            _newsAnnounc.NewsAnnoucStatusToFalse(id);
        }

        public void NewsAnnoucStatusToTrue(int id)
        {
            _newsAnnounc.NewsAnnoucStatusToTrue(id);
        }

        public void Update(NewsAnnouc t)
        {
            _newsAnnounc.Update(t);
        }
    }
}
