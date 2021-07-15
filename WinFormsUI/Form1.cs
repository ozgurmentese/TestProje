using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        IStiService _stiService;
        public Form1()
        {
            InitializeComponent();
            _stiService = InstanceFactory.GetInstance<IStiService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                dataGridView1.DataSource = _stiService.StiJoinStks(textBox1.Text);
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _stiService.StiJoinStks();
        }

        private void Goster_Click(object sender, EventArgs e)
        {
            var tarih1 = Convert.ToDateTime(tbxTarih1.Text);
            int dateToInt = Convert.ToInt32(tarih1.ToOADate());
            var tarih2 = Convert.ToDateTime(tbxTarih2.Text);
            int dateToInt2 = Convert.ToInt32(tarih2.ToOADate());

            if (!String.IsNullOrEmpty(tbxTarih1.Text) && !String.IsNullOrEmpty(tbxTarih1.Text))
            {
                dataGridView1.DataSource = _stiService.GetAll(dateToInt, dateToInt2);
            }
            else
            {
                LoadData();
            }

        }
    }
}
