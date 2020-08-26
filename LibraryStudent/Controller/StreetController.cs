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
        public StreetController()
        {
             Streets = Load <List<Street>>(CITY_FILE_NAME) ?? new List<Street>();
        }
        private void Save()
        {
            Save(CITY_FILE_NAME, Streets);
        }
        
        public void Add(Street street)
        {
            Streets.Add(street);
            Save();
        }
    }
}
