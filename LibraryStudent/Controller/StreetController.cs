using LibraryStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

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

        public void SetParticleValues(int x1, int y1, string name, bool passability, bool contactpoint, int color_num)
        {            
            if (x1 > -1 && x1 <= 20 * CurrentStreet.Map[0].Length + CurrentStreet.Map[0].Length - 1 && x1 > -1 && y1 > -1 && y1 <= 20 * CurrentStreet.Map.Length + CurrentStreet.Map.Length - 1)
            {
                if (String.IsNullOrEmpty(name))
                {
                    throw new Exception("Название ячейки!!!! не может быть пустым!");                    
                }
                CurrentStreet.Map[y1][x1].Name = name;
                CurrentStreet.Map[y1][x1].ColorNum = color_num;
                CurrentStreet.Map[y1][x1].Passability = passability;
                CurrentStreet.Map[y1][x1].ContactPoint = contactpoint;
               // Save();
                //CurrentStreet.Invalidate();
            }
        }

        private void Save()
        {
            Save(CITY_FILE_NAME, Streets);
        }
        
        public void Add(string name, int columns, int rows)
        {
            Street temp = new Street(name, columns, rows);
          //  MessageBox.Show(CurrentStreet.Map.Length.ToString() + " " + temp.Map.Length.ToString());

            for (int y = 0; y < temp.Map.Length; y++)
            {
                for (int x = 0; x < temp.Map[0].Length; x++)
                {
                    temp.Map[y][x].Name = CurrentStreet.Map[y][x].Name;
                    temp.Map[y][x].ColorNum = CurrentStreet.Map[y][x].ColorNum;
                    temp.Map[y][x].Passability = CurrentStreet.Map[y][x].Passability;
                    temp.Map[y][x].ContactPoint =  CurrentStreet.Map[y][x].ContactPoint;
                }
            }
            CurrentStreet = temp;
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
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название улицы не может быть пустым!");
            }
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

        public void SetParticleNum(int X, int Y, int num)
        {
            int x = X / 21;
            int y = Y / 21;
            CurrentStreet.Map[y][x].Num = num;
        }
    }
}
