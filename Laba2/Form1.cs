using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        private MyModel m_dbContext;
        private Map _map;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dbContext = new MyModel();
            DisplayTableInForm();
        }

        private void DisplayTableInForm()
        {
            dataGridBrand.DataSource = m_dbContext.Brands.ToList();
            dataGridBrand.Columns[2].Visible = false;

            dataGridDimension.DataSource = m_dbContext.Dimensions.ToList();
            dataGridDimension.Columns[4].Visible = false;

            dataGridDriver.DataSource = m_dbContext.Drivers.ToList();
            dataGridDriver.Columns[5].Visible = false;
            dataGridDriver.Columns[6].Visible = false;
            dataGridDriver.Columns[7].Visible = false;

            dataGridTransport.DataSource = m_dbContext.Transports.ToList();
            dataGridTransport.Columns[6].Visible = false;
            dataGridTransport.Columns[7].Visible = false;
            dataGridTransport.Columns[8].Visible = false;
            dataGridTransport.Columns[9].Visible = false;
            dataGridTransport.Columns[10].Visible = false;


            dataGridWeight.DataSource = m_dbContext.Weights.ToList();
            dataGridWeight.Columns[2].Visible = false;

            dataGridType.DataSource = m_dbContext.Types.ToList();
            dataGridType.Columns[2].Visible = false;

            dataGridExperience.DataSource = m_dbContext.Experiences.ToList();
            dataGridExperience.Columns[2].Visible = false;

            dataGridRoute.DataSource = m_dbContext.Routes.ToList();
        }

        private void gMapControl_Load(object sender, EventArgs e)
        {
            _map = new Map();
            _map.Init(ref gMapControl);
        }
    }
}
