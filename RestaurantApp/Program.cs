using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("haha");
            Console.WriteLine("week2");

            List<Restaurant> restaurants = new List<Restaurant>
            { 
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot pot", "Hot pot", 4.6),
                new Restaurant(3, "Din Tai Fong", "Taiwanese Cuisine", 4.7),

            };
        }
    }
}
class Restaurant
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Rating { get; set; }

    public Restaurant(int id, string name, string type, double rate)
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.Rating = rate;
    }
}

