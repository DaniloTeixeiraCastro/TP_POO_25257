using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System
{
    public class Accommodation
    {
        public int Id { get; set; }  // Identificador único do alojamento
        public string Name { get; set; }  // Nome do alojamento
        public string Location { get; set; }  // Localização do alojamento
        public int Capacity { get; set; }  // Capacidade máxima de pessoas
        public decimal PricePerNight { get; set; }  // Preço por noite

        // Construtor para inicializar um alojamento
        public Accommodation(int id, string name, string location, int capacity, decimal pricePerNight)
        {
            Id = id;
            Name = name;
            Location = location;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }
    }
}
