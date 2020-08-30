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
        private StreetController streetController = new StreetController();
        private bool flag = false;
        private void DrawMap(Graphics g, int size)
        {
            var map = streetController.CurrentStreet.Map;
            Color[] colors = new Color[7] {
                Color.Orange,
                Color.LightGray,
                Color.Gray,                
                Color.Blue,
                Color.Red,
                Color.Fuchsia,
                Color.DeepSkyBlue
            };
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map[0].Length; x++)
                {

                    g.FillRectangle(new SolidBrush(colors[map[y][x]]), x * size + 1 * (x + 1), y * size + 1 * (y + 1), size, size);
                }
            }
        }

        private void setCount()
        {
            flag = false;
            num_cols.Value = streetController.getWidth();
            num_rows.Value = streetController.getHeight();
            txt_street_name.Text = streetController.CurrentStreet.Name;
            flag = true;

        }

        //
      /*  public Bitmap getScena(int width, int height, int size, int index)
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
        }*/

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {           
            
            streetController.CurrentStreet = new Street(txt_street_name.Text, (int)num_rows.Value, (int)num_cols.Value);           
            streetController.Add();
            lst_names.Items.Add(streetController.Streets.Last().Name);
            scena.Invalidate();
        }

        private void lst_names_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (lst_names.SelectedIndex > -1)
            {
                streetController.CurrentStreet = streetController.Streets[lst_names.SelectedIndex];
                setCount();
            }
            scena.Invalidate();            
        }

        private void scena_Paint(object sender, PaintEventArgs e)
        {
            DrawMap(e.Graphics, 20);
        }

        private void num_cols_ValueChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(num_rows.Value.ToString());
            //  MessageBox.Show(num_cols.Value.ToString());
            if (flag)
            {
                streetController.ChangeSize((int)num_rows.Value, (int)num_cols.Value);
                scena.Invalidate();
            }
                      
        }

        private void num_cols_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(ng());
           
        }

        private void ReloadList()
        {
            lst_names.Items.Clear();
            foreach (var street in streetController.Streets)
            {
                lst_names.Items.Add(street.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadList();
            setCount();
        }

        private void num_rows_ValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                streetController.ChangeSize((int)num_rows.Value, (int)num_cols.Value);
                scena.Invalidate();
            }
           
        }

        private void btn_new_map_Click(object sender, EventArgs e)
        {
           // flag = false;
            streetController.SetNewStreet();
            /*num_cols.Value = streetController.getWidth();
            num_rows.Value = streetController.getHeight();
            txt_street_name.Text = streetController.CurrentStreet.Name;*/
            setCount();
            lst_names.SelectedIndex = -1;
            scena.Invalidate();
           // flag = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {            
            streetController.EditMap(txt_street_name.Text, lst_names.SelectedIndex);
            ReloadList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            streetController.Delete(lst_names.SelectedIndex);
            ReloadList();
        }
    }
}
