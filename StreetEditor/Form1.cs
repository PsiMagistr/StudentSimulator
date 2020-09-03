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
        private bool flag2 = false;
        private bool draw = false;
        private int X;
        private int Y;
        private void DrawMap(Graphics g, int size)
        {
            var map = streetController.CurrentStreet.Map;
            Color[] colors = new Color[8] {
                Color.LightGreen,               
                Color.Gray,
                Color.Orange,
                Color.LightGray,                
                Color.Blue,
                Color.Red,
                Color.Fuchsia,
                Color.DeepSkyBlue
            };
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map[0].Length; x++)
                {

                    g.FillRectangle(new SolidBrush(colors[map[y][x].ColorNum]), x * size + 1 * (x + 1), y * size + 1 * (y + 1), size, size);
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

        private void DrawBorder(Graphics f)
        {
            if (X > -1 && Y <= 20 * streetController.CurrentStreet.Map[0].Length + streetController.CurrentStreet.Map[0].Length - 1 && X > -1 && Y > -1 && Y <= 20 * streetController.CurrentStreet.Map.Length + streetController.CurrentStreet.Map.Length - 1)
            {

                /*int x = x1 / 21;
                int y = y1 / 21;*/
                if (flag2)
                {
                    f.DrawRectangle(new Pen(Color.Black), X *21, Y *21, 20, 20);
                }             
                
            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            /// 
            //streetController.CurrentStreet.Name = txt_street_name.Text;
            try
            {
                streetController.Add(txt_street_name.Text, (int)num_rows.Value, (int)num_cols.Value);
                lst_names.Items.Add(streetController.Streets.Last().Name);
                scena.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void lst_names_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (lst_names.SelectedIndex > -1)
            {
                flag2 = false;
                streetController.CurrentStreet = streetController.Streets[lst_names.SelectedIndex];
                setCount();
            }
            scena.Invalidate();            
        }

        private void scena_Paint(object sender, PaintEventArgs e)
        {
            DrawMap(e.Graphics, 20);
            DrawBorder(e.Graphics);
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
            //MessageBox.Show(streetController.Streets[0].Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst_commands.SelectedIndex = 0;
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
           
            streetController.SetNewStreet();            
            setCount();
            lst_names.SelectedIndex = -1;
            scena.Invalidate();           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lst_names.SelectedIndex;
                streetController.EditMap(txt_street_name.Text, index);
                ReloadList();
                lst_names.SelectedIndex = index;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            streetController.Delete(lst_names.SelectedIndex);
            ReloadList();
        }

        private void scena_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                try
                {
                    X = e.X / 21;
                    Y = e.Y / 21;
                    streetController.SetParticleValues(X, Y, txt_name_of_ceil.Text, ch_passability.Checked, ch_contact.Checked, lst_commands.SelectedIndex - 1);
                    scena.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    draw = false;

                }             
               
            }
            
            //info.Text = streetController.CurrentStreet.Map[0][0].Name;
        }

        private void scena_MouseDown(object sender, MouseEventArgs e)
        {
            if (lst_commands.SelectedIndex > 0)
            {
                draw = true;
                flag2 = false;
            }
            else
            {
                flag2 = true;
                X = e.X / 21;
                Y = e.Y / 21;                
                txt_name_of_ceil.Text = streetController.CurrentStreet.Map[Y][X].Name;
                ch_passability.Checked = streetController.CurrentStreet.Map[Y][X].Passability;
                ch_contact.Checked = streetController.CurrentStreet.Map[Y][X].ContactPoint;
                scena.Invalidate();
            }
        }

        private void scena_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void btn_chane_value_Click(object sender, EventArgs e)
        {
            try
            {
                streetController.SetParticleValues(X, Y, txt_name_of_ceil.Text, ch_passability.Checked, ch_contact.Checked, streetController.CurrentStreet.Map[Y][X].ColorNum);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
