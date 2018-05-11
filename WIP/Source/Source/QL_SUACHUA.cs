using Source.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source
{
    public partial class QL_SUACHUA : Form
    {
        
        public QL_SUACHUA()
        {
            InitializeComponent();
            loadthongtinsc();

        }
        public void loadthongtinsc()
        {
            //EXEC GETACCOUNTBYUSERNAME @USERNAME
           // string query = "SELECT *FROM dbo.THONGTINSUACHUA ";
            //string query = "INSERT INTO TAIKHOAN VALUES('TK06','NV6','123456','07/02/1788')";
            //DATAPROVIDER provider = new DATAPROVIDER();

            //dataGridView1.DataSource = provider.Executequery(query/*,new object[] { "NV2" }*/);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
