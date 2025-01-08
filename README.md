# School Management System

## C# Class Kullanımı ve OOP'ye Giriş.

![Person Class](https://github.com/ugurarican/SchoolManagementSystem/blob/master/person%20class.png)  
Person adında oluşturduğum class.

![SchoolManagmentSystem Class](https://github.com/ugurarican/SchoolManagementSystem/blob/master/person%20class.png)  
School Management System (Main) classım.

![Display](https://github.com/ugurarican/SchoolManagementSystem/blob/master/display.png)  
Programın ekran çıktısı.

##  Yapılan İşlem
Person adında bir class oluşturuldu içerisine Ad, Soyad ve Doğum Tarihi değişkenleri private oalrak atandı.
Böylece sadece bu classta erişime izin verilmiş oldu. (OOP'nin 4 prensibinden Encapsulation yapılmış oldu.)
Değişkenlerle aynı isimde ama PascalCasing yazım standartıyla yazılmış olan Propertyler tanımlandı.
Bu properylerde get ile ifadeyi dışarıya döndürdük, set ile private olarak tanımlanan değişkenimizin değer atamasını yapmış olduk.
En sonda da Show Infermotion adında bir metot oluşturuldu bu metot ile de oluşturulan nesnenin bilgilerini ekrana basması kodlandı.

Main classımızda öğrenci veya öğretmen olarak isimlendirdiğimiz Person nesnemizi new komutu ile oluşturduk.
Oşuturulan öğrenci ve öğretmen nesnelerinin ShowInfermation metodunu çağırarak ekrana bilgilerini yazmasını sağladık.
