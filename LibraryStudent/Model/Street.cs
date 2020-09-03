using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStudent.Model
{
    [Serializable]
    public class Street {
        private string name;
        public string Name { get { return name; } set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название улицы не может быть совсем пустым!");
                }
                name = value;
            } }                
        public Particle[][] Map { get; set; }
        public Street(string name, int columns, int rows)
        {           
            Name = name; // ?? //throw new ArgumentNullException("Название улицы не может быть пустым.");
            Map = new Particle[columns][];
            for (int i = 0; i < Map.Length; i++)
            {
                Map[i] = new Particle[rows];              
            }
             for (var y = 0; y < columns; y++)
             {
                 for (var x = 0; x < rows; x++)
                 {                    
                    Map[y][x] = new Particle("Трава", true, false, 0, 0);
                 }
             }            
        }
    }
}
