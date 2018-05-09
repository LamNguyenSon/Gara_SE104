using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.DAO
{
    public class accountDAO
    {
        public static  accountDAO instance;

        public accountDAO Instance
        {
            get { if (instance == null) instance = new accountDAO(); return instance;  }
            private set { instance = value; }
        }
        public accountDAO() { }
        public bool login(string username,string password)
        {
            String query = "SELECT *FROM TAIKHOAN WHERE TENDN=N'" + username + "' AND MATKHAU='" + password + "' ";
            DATAPROVIDER data = new DATAPROVIDER();
            DataTable result = data.Executequery(query);
            return result.Rows.Count>0;//ĐẾM SỐ DÒNG
        }

    }
}
