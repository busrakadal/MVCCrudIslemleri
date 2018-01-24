using MVCCrudIslemleri.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCrudIslemleri.Repositories.Abstracts
{
    public interface IUnitOfWork:IDisposable
    {
        //transaction yönetimi için rollback yada commit yapıcak
        //savechanges() işleminde bunu anlayabiliriz.
        bool Commit();
        //UnitOfWork üzerinden Repository Ulaşmak için kulladığımız bir yöntem
        IRepository<T> GetRepo<T>() where T:EntityBase,new();

        void Dispose(bool disposing);

        //1.Repository bağlantısı
        //2.Database Bağlantısı Tek bir yerden yürütülsün
        //3.Transaction yönetimi

    }
}
