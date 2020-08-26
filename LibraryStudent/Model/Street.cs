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
        public int[][] Map { get; set; }
        public Street(string name, int columns, int rows)
        {
            Name = name;
            Map = new int[columns][];
            for (int i = 0; i < Map.Length; i++)
            {
                Map[i] = new int[rows];
            }
        }
    }
}
