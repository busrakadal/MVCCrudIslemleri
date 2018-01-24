using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrudIslemleri.Data.Entities
{

    //POCO classlarının veya POCO Class propertylerin üzerine attribute -[Required()]- gibi tanımlama yapma işlemine DataAnnotations denir. SOLID prensiplerine göre  sınıflar sadece veri taşıma görevi üstlenmeli ve database ile ilgili herhangi bir ayar içermemelidir bu sebeple Fluent API yöntemini DataAnnotations yerine tercih ettik.

    //POCO classes
    public class Product:EntityBase
    {
        //yazdığımız property PK olması için ID veya Id ile bitmesi gerekiyor.
        //EF Default Conventions yapıyor bunu
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }
        //EF Default Conventions yapıyor bunu category ile product ileişkili olduğundan property FK yapacaktır.
        public int CategoryId { get; set; }

        //virtual ön takısı koyulduğu anda otomatik olarak tablolar arası lazy loading eager loading gibi ilişkili tabloların çalışma zamanında yüklenmesi gibi EF ait stratejiler ayağa kalkar.
        //virtual yazmaksak da ilişki vardır sadece yukarıdaki stratejilere yer verilmez.
        public virtual Category Category { get; set; }

        
    }
}