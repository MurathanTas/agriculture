using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewsAnnoucService:IGenericService<NewsAnnouc>
    {
        void NewsAnnoucStatusToTrue(int id);
        void NewsAnnoucStatusToFalse(int id);
    }
}
