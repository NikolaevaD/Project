using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project
{

    public partial class Form1 : Form
    {
        
        protected Читатель form_4itatel; // форма читателя
        protected Form3 form_sotrudnik; // форма сотрудника
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 4itatel'
            form_4itatel = new Читатель();
            form_4itatel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sotrudnik
            form_sotrudnik = new Form3();
            form_sotrudnik.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
