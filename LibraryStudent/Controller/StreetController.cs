using LibraryStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStudent.Controller
{
    [Serializable]
    public class StreetController:Saver
    {
        public List<Street> Streets { get; private set; }
        private const string CITY_FILE_NAME = "city.dat";
        public Street CurrentStreet {get; set;}
        
        public StreetController()
        {
             Streets = Load <List<Street>>(CITY_FILE_NAME) ?? new List<Street>();
             SetNewStreet();
        }

        public void SetNewStreet()
        {
            CurrentStreet = new Street("Безымянный", 24, 45);
        }

        public void Change(int y, int x, int value)
        {
            CurrentStreet.Map[y][x] = value;
        }

        private void Save()
        {
            Save(CITY_FILE_NAME, Streets);
        }
        
        public void Add()
        {
            Streets.Add(CurrentStreet);
            Save();
        }

        public int getWidth()
        {
            return CurrentStreet.Map[0].Length;
        }

        public int getHeight()
        {
            return CurrentStreet.Map.Length;
        }

        public void EditMap(string name, int index)
        {
            CurrentStreet.Name = name;
            Streets[index] = CurrentStreet;
            Save();
        }

        public void ChangeSize(int cols, int rows)
        {
            Street s = new Street(CurrentStreet.Name, cols, rows);
            for (int y = 0; y < cols; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    if (y < CurrentStreet.Map.Length && x < CurrentStreet.Map[0].Length)
                    {
                        s.Map[y][x] = CurrentStreet.Map[y][x];
                    }                    
                }
            }
            CurrentStreet = s;
        }

        public void Delete(int index)
        {
            Streets.RemoveAt(index);
            Save();
        }
    }
}
