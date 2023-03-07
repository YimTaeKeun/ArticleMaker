using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class RemoteController : Form
    {
        Form del_form;
        public RemoteController(Form delegate_form)
        {
            InitializeComponent();
            del_form = delegate_form;
        }

        private void RemoteController_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName == null)
                    throw new Exception("경로를 지정해주세요");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
