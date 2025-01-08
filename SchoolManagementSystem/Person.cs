using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    internal class Person
    {
        //field bölümünde değişkenlerimizi tanımlıyoruz ve private erişim belirleyicisi ile sadece bu classta erişim sağlıyoruz.(Encapsulation)
        private string ad;
        private string soyad;
        private DateTime dogumTarihi;

        //Propertyler ile bu değişkenlerimizi diğer claslardan okunabilir veya yazılabilir yapıyoruz. (Get, Set ile)
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }
        //Ekrana yazmak için bir metot tanımlıyoruz.
        public void ShowInformation()
        {
            Console.WriteLine($"{ad} {soyad} {dogumTarihi.ToString("dd.MM.yyyy")}");
        }
    }
}
