using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Rezervasyon
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdCard { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public bool HasSpecialNeeds { get; set; }

        public Customer(string name, string surname, string ıdcard, string phoneno, string email, bool hasSpecialNeeds)
            {
                Name = name;
                Surname = surname;
                IdCard = ıdcard;
                PhoneNo = phoneno;
                Email = email;
                HasSpecialNeeds = hasSpecialNeeds;
            }

                public override string ToString()
                {
                    return $"AD-SOYAD = {Name}-{Surname} | KİMLİK-NO = {IdCard} | TEL-NO = {PhoneNo} | E-MAİL = {Email} | ENGEL DURUMU = {HasSpecialNeeds}\n";
                }
    }
}
