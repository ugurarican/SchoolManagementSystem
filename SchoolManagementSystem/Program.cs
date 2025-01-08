using SchoolManagementSystem;

//Öğrenci 1 nesnesi oluşturuldu ve özellikleri tanımladı.
Person student1 = new Person();
student1.Ad = "Kamil";
student1.Soyad = "ÖZTÜRK";
student1.DogumTarihi = new DateTime(1999, 5, 15);

//Öğrenci 2 nesnesi oluşturuldu ve özellikleri tanımladı.
Person student2 = new Person();
student2.Ad = "Ayşe";
student2.Soyad = "GÜVEN";
student2.DogumTarihi = new DateTime(1998, 2, 26);

//Öğrenci 3 nesnesi oluşturuldu ve özellikleri tanımladı.
Person student3 = new Person();
student3.Ad = "Başak";
student3.Soyad = "HASÇELİK";
student3.DogumTarihi = new DateTime(1996, 1, 10);

//Öğretmen 1 nesnesi oluşturuldu ve özellikleri tanımladı.
Person teacher1 = new Person();
teacher1.Ad = "Gizem";
teacher1.Soyad = "ULU";
teacher1.DogumTarihi = new DateTime(1991, 11, 7);

//Öğretmen 2 nesnesi oluşturuldu ve özellikleri tanımladı.
Person teacher2 = new Person();
teacher2.Ad = "Mahmut";
teacher2.Soyad = "ORHAN";
teacher2.DogumTarihi = new DateTime(1992, 3, 7);

// Öğrenci ve öğretmenler için Person sınıfının içerisindeki Show Information metodu çalıştırıldı.
student1.ShowInformation();
student2.ShowInformation();
student3.ShowInformation();
teacher1.ShowInformation();
teacher2.ShowInformation();