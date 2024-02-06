using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class cereal
    {
        public string name { get; set; }
        public string slogan { get; set; }
        public Boolean clarkAprooved { get; set; }
        public int calories { get; set; }
        public decimal Price { get; set; }
        public string picture { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cereal luckycharms=new cereal();
            luckycharms.name = "Lucky Charms";
            luckycharms.slogan = "they're magically Delicious";
            luckycharms.clarkAprooved = true;
            luckycharms.calories = 137;
            luckycharms.Price = 15.37m;

            cereal frostedflakes=new cereal();
            frostedflakes.name = "Frosted Flakes";
            frostedflakes.slogan = "They're Grrrrrrreat";
            frostedflakes.clarkAprooved= true;
            frostedflakes.Price = 9.96m;
            frostedflakes.calories = 111;
        }
    }
}
