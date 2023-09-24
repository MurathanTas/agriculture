using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INewsAnnouncDal:IGenericDal<NewsAnnouc>
    {
        void NewsAnnoucStatusToTrue(int id);
        void NewsAnnoucStatusToFalse(int id);
    }
}
