using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonelBL:IDisposable

    {
          OtobusDBContext ctx = new  OtobusDBContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public bool Ekle(Personel p)
        {
            ctx.Personeler.Add(p);
            return ctx.SaveChanges() > 0;
        }
        public bool Güncele(Personel p)
        {

            ctx.Personeler.Where(p=>p.Ad);
            return ctx.SaveChanges() > 0;

        }



    }
}
