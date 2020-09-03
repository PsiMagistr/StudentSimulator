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
        private string name;
        public string Name { get { return name; } set {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название ячейки никак не может быть пустым....");
                }
                name = value;
            } }
        public bool Passability { get; set; }
        public int ColorNum { get; set; }
        public bool ContactPoint { get; set; }
        [NonSerialized]
        private int num;
        public int Num { get { return num; } set { num = value; } }
        public Particle(string name, bool passability, bool contactpoint, int num, int colornum)
        {            
            Name = name;
            Passability = passability;
            ContactPoint = contactpoint;
            Num = num;
            ColorNum = colornum;
        }
    }
}
