using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.DAO
{
	class DATAPROVIDER
	{
		///////singleton
		public static DATAPROVIDER instance;


		public DATAPROVIDER Instance
		{
			get { if (instance == null) instance = new DATAPROVIDER(); return instance; }
			private set { instance = value; }
		}

        //public DATAPROVIDER Instance
        //{
        //    get { if (instance == null) instance = new DATAPROVIDER(); return instance; }
        //    private set { instance = value; }
        //}
        public DATAPROVIDER()
        {
        }


		private string connectionstr = @"Data Source=DESKTOP-6PU4NRQ;Initial Catalog=QL_GARA;Integrated Security=True";
		public DataTable Executequery(string query, Object[] para = null)
		{
			SqlConnection connection = new SqlConnection(connectionstr);
			connection.Open();
			SqlCommand command = new SqlCommand(query, connection);

			if (para != null)
			{
				string[] listpara = query.Split(' ');
				int i = 0;
				foreach (string item in listpara)
				{
					if (item.Contains('@'))
					{
						command.Parameters.AddWithValue(item, para[i]);
						i++;
					}
				}
			}

			DataTable data = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(data);
			connection.Close();
			return data;
		}


		public int Executenonquery(string query, Object[] para = null)
		{
			int data = 0;
			SqlConnection connection = new SqlConnection(connectionstr);
			connection.Open();
			SqlCommand command = new SqlCommand(query, connection);

			if (para != null)
			{
				string[] listpara = query.Split(' ');
				int i = 0;
				foreach (string item in listpara)
				{
					if (item.Contains('@'))
					{
						command.Parameters.AddWithValue(item, para[i]);
						i++;
					}
				}
			}

			data = command.ExecuteNonQuery();
			connection.Close();
			return data;
		}



		public object Executescalarquery(string query, Object[] para = null)
		{
			object data = 0;
			SqlConnection connection = new SqlConnection(connectionstr);
			connection.Open();
			SqlCommand command = new SqlCommand(query, connection);

			if (para != null)
			{
				string[] listpara = query.Split(' ');
				int i = 0;
				foreach (string item in listpara)
				{
					if (item.Contains('@'))
					{
						command.Parameters.AddWithValue(item, para[i]);
						i++;
					}
				}
			}

			data = command.ExecuteScalar();
			connection.Close();
			return data;
		}
	}
}
