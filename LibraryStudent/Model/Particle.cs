using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStudent.Model
{
    [Serializable]
    public class Particle
    {
        public string Name { get; set; }
        public bool Passability { get; set; }
        public int ColorNum { get; set; }
        public bool ContactPoint { get; set; }
        public int Num { get; set; }
        public Particle(string name, bool passability, bool contactpoint, int num)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название ячейки не может быть пустым...."); 
            }
            Name = name;
            Passability = passability;
            ContactPoint = contactpoint;
            Num = num;
            ColorNum = 0;
        }
    }
}
