using LibraryStudent.Controller;
using LibraryStudent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetEditor
{
    public partial class Form1 : Form
    {
        public StreetController streetController = new StreetController();
        public Bitmap getScena(int width, int height, int size, int index)
        {
            Bitmap picture = new Bitmap(width, height);
            int[][] map = streetController.Streets[index].Map;
            Graphics g = Graphics.FromImage(picture);
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map[0].Length; x++)
                {

                    g.FillRectangle(new SolidBrush(Color.Red), x * size + 1 * (x + 1), y * size + 1 * (y + 1), size, size);
                }
            }
            return picture;           
        }

        public Form1()
        {
            InitializeComponent();
            foreach (var street in streetController.Streets)
            {
                lst_names.Items.Add(street.Name);
            }

            if(streetController.Streets.Count > -1)
            {
                scena.Image = getScena(scena.Width, scena.Height, 20, 0);
            }            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Street street = new Street(txt_street_name.Text, 5, 5); 
            streetController.Add(street);
            lst_names.Items.Add(streetController.Streets.Last().Name);
        }
    }
}
