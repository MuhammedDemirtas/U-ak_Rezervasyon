# Uçak Rezervasyon Projesi
Bu proje bir uçak rezervasyon uygulamasıdır. Kullanıcı, adı, soyadı, kimlik numarası, telefon numarası, e-posta adresi ve özel ihtiyaçları var mı yok mu gibi kişisel bilgilerini girdikten sonra, kalkış ve varış noktalarını, seyahat tarihlerini ve tercih edilen uçağı seçebilir. Ardından, size verilen saat ve koltuk numarasını ekrana yazdırıp uçuş rezervasyonu oluşturulur ve kullanıcıya gösterilir.
Uygulama, C# programlama dili kullanılarak geliştirilmiştir. Veriler, sınıflar kullanılarak yönetilir ve kullanıcının girdiği bilgiler kullanılarak bir rezervasyon oluşturulur. Uygulama, kullanıcıya çeşitli bilgileri ve seçenekleri sormak için konsol arayüzünü kullanır.
Uygulama, uçak ve havalimanı bilgilerini içeren iki ayrı sınıf kullanır. Uçak bilgileri, uçak markası, yolcu kapasitesi, hızı ve sınıfı gibi bilgileri içeren bir Aircraft sınıfında tutulurken, havalimanı bilgileri, havalimanı adı ve şehir gibi bilgileri içeren bir Location sınıfında tutulur. Bu bilgiler, kullanıcıya seyahat seçenekleri sunmak için kullanılır.

-----------------------------------------------------------------------------------------------------------------

Reservation Class = Bu sınıf, bir uçak rezervasyonunu temsil etmek için kullanılır. Sınıf, uçuşun bilgilerini (uçak, kalkış ve varış noktaları, kalkış ve varış tarihleri, müşteri, koltuk numarası ve saati) tutar. Sınıf ayrıca rastgele bir koltuk numarası ve saat oluşturmak için bir Random sınıfı kullanır. ToString() metodu, sınıfın bilgilerini bir dize olarak formatlar ve rezervasyon işleminin tamamlandığına dair bir mesajla birlikte döndürür.

-----------------------------------------------------------------------------------------------------------------

Aircraft Class = Bu sınıf, uçağın adı, kapasitesi, hızı, sınıfı ve fiyatı gibi özellikleri tutar. Sınıfın constructor metodu, uçak modeli oluştururken uçak fiyatını rastgele bir değer olarak belirler. ToString() metodu, sınıfın özelliklerini bir dize olarak formatlar ve döndürür.

-----------------------------------------------------------------------------------------------------------------

Customer Class = Bu sınıf, bir müşterinin bilgilerini temsil etmek için kullanılır. Sınıf, müşterinin adı, soyadı, kimlik numarası, telefon numarası, e-posta adresi ve özel ihtiyaçları olup olmadığı gibi özellikleri tutar. Sınıfın constructor metodu, müşteri oluşturulurken bu özelliklerin değerlerini alır. ToString() metodu, sınıfın özelliklerini bir dize olarak formatlar ve döndürür.

-----------------------------------------------------------------------------------------------------------------

Location Class =  Bu sınıf, bir konumun bilgilerini temsil etmek için kullanılır. Sınıf, konumun ülke adı, şehir adı ve havaalanı gibi özellikleri tutar. Sınıfın constructor metodu, konum oluşturulurken bu özelliklerin değerlerini alır. ToString() metodu, sınıfın özelliklerini bir dize olarak formatlar ve döndürür

-----------------------------------------------------------------------------------------------------------------

LocationManager Class = Bu sınıf, "Location" sınıfından nesnelerin bir dizisini döndüren ve sabit bir dizi yerleşim bilgisi sağlayan bir "LocationManager" sınıfıdır.

-----------------------------------------------------------------------------------------------------------------

AircraftManager Class = Bu sınıf, uçakları bir dizi olarak döndürür. Her uçak, adı, kapasitesi, hızı, sınıfı ve fiyatı gibi özelliklere sahip bir Aircraft nesnesidir. Bu bilgiler, bilet fiyatlarının ve uçuş planlarının belirlenmesinde kullanılabilir.

-----------------------------------------------------------------------------------------------------------------

Program Class =  Program sınıfı, konsol uygulamasının ana yapısını oluşturan ve diğer sınıfları kullanarak rezervasyon işlemlerini gerçekleştiren bir arayüzdür =

   +Bu sınıf içinde yer alan Main() metodu, uygulamanın başlatıldığı yerdir.

   +Main() metodu, string[] args parametresi alır. Bu parametre, uygulamaya başlatıldığında kullanıcının argüman olarak verdiği değerleri içerir.

   +Console.Title = "MHDMRTŞ-BİLET.COM" satırı, uygulamanıza başlık yazmak isterseniz kullanmanız gereken komut.

   +Console.WriteLine() metodu, ekrana yazı yazdırmak için kullanılır.

   +AircraftManager sınıfından bir nesne oluşturulur ve GetAircrafts() metodu çağrılarak uçaklar dizi olarak alınır.

   +LocationManager sınıfından bir nesne oluşturulur ve GetLocations() metodu çağrılarak havalimanları dizi olarak alınır.

   +Kullanıcıdan gerekli bilgiler (ad, soyad, kimlik no, telefon no, e-posta ve özel ihtiyaç var mı) alınır ve ilgili değişkenlere atanır.

   +Kullanıcıya mevcut havalimanları listesi gösterilir ve kalkış ve varış noktaları belirlemesi istenir. Kalkış ve varış noktaları aynı olamaz, bu nedenle bu koşulu sağlaması için bir  döngü  kullanılır.

   +Kullanıcıya mevcut uçaklar listesi gösterilir ve uçak tercihi istenir.

   +Kullanıcıdan gidiş ve dönüş tarihleri istenir. Bu tarihler, DateTime sınıfının ParseExact() metodu kullanılarak dd.MM.yyyy formatında alınır.
   
   +Daha sonra kullanıcının seçtiği tarihte boşta olan bir koltuk numarasını ve saati gösterir ve kullanıcının kabul edip devam etmek için Enter tuşuna basmasını bekler.

   +Müşteri ve rezervasyon nesneleri oluşturulur ve konsola rezervasyon bilgileri yazdırılır.

   +Kullanıcının programı kapatmadan önce sonucu görmesi için Console.ReadLine() kullanılır. Bu, son işlemdir.
 
 -----------------------------------------------------------------------------------------------------------------
