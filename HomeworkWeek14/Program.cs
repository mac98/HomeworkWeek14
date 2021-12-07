using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek14
{
    class Program
    {
        static void Main(string[] args)
        {
            People[] list_of_peeps = new People[10];
            list_of_peeps[0] = new People("Gary", 47, 65);
            list_of_peeps[1] = new People("Debby", 28, 68);
            list_of_peeps[2] = new People("Beatrice", 33, 62);
            list_of_peeps[3] = new People("Filmore", 19, 73);
            list_of_peeps[4] = new People("Manuel", 12, 53);
            list_of_peeps[5] = new People("Samual", 49, 62);
            list_of_peeps[6] = new People("Samantha", 9, 39);
            list_of_peeps[7] = new People("Jimmy", 15, 57);
            list_of_peeps[8] = new People("Felix", 27, 64);
            list_of_peeps[9] = new People("Felicia", 11, 51);

            foreach (People peep in list_of_peeps)
            {
                Console.WriteLine(peep.Name);
            }

            List<People> list_of_kids = new List<People>();
            Console.WriteLine("\nKids (under 12) in People List: ");
            foreach (People peep in list_of_peeps)
            {
                if (peep.Age <= 12)
                {
                    if (list_of_kids.Count > 0)
                        Console.Write(", ");
                    list_of_kids.Add(peep);
                    Console.Write(peep.Name);
                }
            }
            
            int avg_hgt = 0;
            foreach (People peep in list_of_peeps)
            {
                avg_hgt += peep.Height;
            }
            avg_hgt /= list_of_peeps.Length;

            List<People> list_of_talls = new List<People>();
            Console.WriteLine("\n\nTaller than average peeps: ");
            foreach (People peep in list_of_peeps)
            {
                if (peep.Height > avg_hgt)
                {
                    if (list_of_talls.Count() > 0)
                        Console.Write(", ");
                    list_of_talls.Add(peep);
                    Console.Write(peep.Name);
                }
            }
            Console.Read();
            
        }
    }

    class People
    {
        private string name; //in chars
        public string Name { get { return name; } set { name = value; } }

        private int age;     //in years
        public int Age { get { return age; } set { age = value; } }

        private int height;  //in inches
        public int Height { get { return height; } set { height = value; } }

        public People()
        {
            age = 0;
            height = 0;
        }

        public People(string _name, int _age, int _height)
        {
            name = _name;
            age = _age;
            height = _height;
        }
    }
}
