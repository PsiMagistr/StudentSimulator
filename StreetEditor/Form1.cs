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
        public Form1()
        {
            InitializeComponent();
            foreach (var street in streetController.Streets)
            {
                lst_names.Items.Add(street.Name);
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
