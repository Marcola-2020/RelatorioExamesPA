using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatorioExamesPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ClinicaDataSet.Relatorio'. Você pode movê-la ou removê-la conforme necessário.
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RelatorioTableAdapter.Fill(this.ClinicaDataSet.Relatorio,  Convert.ToInt32(textBox1.Text), dateTimePicker1.Value.Date);

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
