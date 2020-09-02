using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStudent.Model
{
    [Serializable]
    public class Street
    {
        public string Name { get; set; }
        public Particle[][] Map { get; set; }
        public Street(string name, int columns, int rows)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Название улицы не может быть пустым.");
            }
            Name = name; // ?? //throw new ArgumentNullException("Название улицы не может быть пустым.");
            Map = new Particle[columns][];
            for (int i = 0; i < Map.Length; i++)
            {
                Map[i] = new Particle[rows];
               /* Map[columns][rows].Name = "Трава";
                Map[columns][rows].ContactPoint = false;
                Map[columns][rows].Num = 0;
                Map[columns][rows].Passability = false;*/
            }
             for (var y = 0; y < columns; y++)
             {
                 for (var x = 0; x < rows; x++)
                 {                    
                    Map[y][x] = new Particle("Трава", true, false, 0);
                 }
             }            
        }
    }
}
