using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uçak_Rezervasyon;

namespace Uçak_Rezervasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MHDMRTŞ-BİLET.COM";

            Console.WriteLine("            |-|Uçak Rezervason Uygulamamıza Hoş Geldin|-|\n");
            Console.WriteLine("                      |-|Doğru Yerdesiniz|-|\n");

            AircraftManager aircraftManager = new AircraftManager();
            Aircraft[] aircrafts = AircraftManager.GetAircrafts();

            LocationManager locationManager = new LocationManager();
            Location[] locations = LocationManager.GetLocations();

            Console.Write("> Lütfen Adınızı (Name's) Girin = ");
            string name = Console.ReadLine();

            Console.Write("> Lütfen Soyadınızı (Surname's) Girin = ");
            string surname = Console.ReadLine();

            Console.Write("> Lütfen KimlikNo (ID Card's) Girin = ");
            string ıdcard = Console.ReadLine();

            Console.Write("> Lütfen Telefon Numaranızı (Phone Number's) Girin = ");
            string phoneno = Console.ReadLine();

            Console.Write("> Lütfen E-posta Adresinizi (E-mail address's) Girin = ");
            string email = Console.ReadLine();

            Console.Write("> Engeliniz Var mı (Has Special Needs - e/h ) ? (e/h): ");
            bool hasSpecialNeeds = Console.ReadLine().ToLower() == "e";

            Console.WriteLine("\n|Şu An Aktif Olan Uçuş Ve Havalimanı Güzergahları| \n");

            Console.WriteLine("> Mevcut Uçuş Noktaları (Available Loactions's) = \n");
            for (int i = 0; i < locations.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {locations[i]}");
            }

            Location departure;
            Location destination;

            while (true)
            {
                Console.Write("\n> Lütfen Kalkış Noktası Numarasını (Departure Number's) Girin = ");
                int departureIndex = int.Parse(Console.ReadLine()) - 1;
                departure = locations[departureIndex];

                Console.Write("\n> Lütfen Varış Noktası Numarasını (Arrival Number's) Girin = ");
                int destinationIndex = int.Parse(Console.ReadLine()) - 1;
                destination = locations[destinationIndex];

                if (departureIndex != destinationIndex)
                {
                    break;
                }

                Console.WriteLine("\n!!DİKKAT = Kalkış Noktası Ve Varış Noktası Aynı Olamaz Tekrar Giriniz(Mistake, Try Again).\n");
            }

            Console.WriteLine("\n|Şu An Aktif Olan Uçaklar Ve Boş Koltuk - Hız Bilgileri| \n");

            Console.WriteLine("> Mevcut Uçaklar (Available Aircrafts) = ");
            for (int i = 0; i < aircrafts.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {aircrafts[i]}");
            }

            Console.Write("\n> Lütfen Uçak Tercihinizi Yapın (flight Choice's) = ");
            int aircraftIndex = int.Parse(Console.ReadLine()) - 1;
            Aircraft aircraft = aircrafts[aircraftIndex];

            Console.WriteLine("\n|TARİH(DATE)| \n");

            Console.Write("> Lütfen Gidiş Tarihini (gg.aa.yyyy) (Departure Date dd.MM.yyyy) Girin = ");
            DateTime departureDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            Console.Write("\n>Lütfen Dönüş Tarihini (gg.aa.yyyy) (Return Date dd.MM.yyyy) Girin = ");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            Customer customer = new Customer(name, surname, ıdcard, phoneno, email, hasSpecialNeeds);
            Reservation reservation = new Reservation(aircraft, departure, destination, departureDate, returnDate, customer);

            Console.Write("\n>Boşta Olan Koltuk Numarası (Empty Seat Number) = ");
            Console.WriteLine(reservation.SeatNumber);

            Console.Write("\n>Rezervasyon Saatiniz (Reservation Time) = ");
            Console.WriteLine(reservation.ReservationTime);

            Console.Write("\n>Kabul Etmek İçin Enter'a Basın (Enter for Accept) = ");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n|Rezervasyonunuz Oluşturulmuştur Aşağıda Görebilirsiniz (Reservation's Confirmed)| \n");
            Console.WriteLine(reservation);

            Console.ReadLine();
        }
    }
}