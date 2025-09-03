using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNetshop.formularios
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            fechaNacimiento.Format = DateTimePickerFormat.Custom;
            fechaNacimiento.CustomFormat = "dd/MM/yyyy";
        }
    }
}
