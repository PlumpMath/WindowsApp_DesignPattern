using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_DataAdapterPattern
{
    public partial class Alpha_form1 : Form
    {
        private Alpha_DataAdapter data;

        public Alpha_form1()
        {
            InitializeComponent();
            data = new Alpha_DataAdapter();
        }

        private void seedDataAdapter()
        {
            //Would need to update all input fields in the data adapter
            data.seedData(textBox1.Text);
            
        }

        private void populateForm()
        {
            //Would need to update all input fields from the classes responsible for logic
            textBox2.Text = data.Text2();
            label1.Text = data.Label1();

        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            //All button clicks actions can be referenced back to one function
            seedDataAdapter();
            populateForm();
        }



        

        
    }
}
