using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TIN { get; set; } //nif
        public DateTime BirthDate { get; set; }

        // Construtor dos objetos do cliente
        public Client(int id, string name, string email, string phone, string tin, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            TIN = tin;
            BirthDate = birthDate;
        }

        // Método para verificar se o cliente é maior de idade
        public bool IsAdult()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            // Verifica se o aniversário já passou neste ano
            if (BirthDate > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            else
            
            {
                Console.WriteLine("You need to be +18 to do a reservation");
            }

            return age >= 18;
        }
    }
}
