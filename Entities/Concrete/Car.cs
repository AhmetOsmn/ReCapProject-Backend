using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }    //Marka
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public double DailyPrice { get; set; }  //Gunluk fiyati
        public string Description { get; set; } //Aciklama
    }
}
