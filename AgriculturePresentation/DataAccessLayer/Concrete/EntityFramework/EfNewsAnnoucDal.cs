using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfNewsAnnoucDal : GenericRepository<NewsAnnouc>, INewsAnnouncDal
    {
        public void NewsAnnoucStatusToFalse(int id)
        {
            using var context = new AgricultureeContext();
            NewsAnnouc p = context.NewsAnnoucs.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void NewsAnnoucStatusToTrue(int id)
        {
            using var context = new AgricultureeContext();
            NewsAnnouc p = context.NewsAnnoucs.Find(id);
            p.Status = true;
            context.SaveChanges();
            
        }
    }
}
