using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PersonnelRegistrationAutomation
{
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonelVerıTabanı;Integrated Security=True");
        private void Graphics_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select PerSehir, Count(*) from Tbl_Personel group by PerSehir", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chart1.Series["Cities"].Points.AddXY(sqlDataReader[0], sqlDataReader[1]);
            }
            sqlDataReader.Close();
            SqlCommand sqlCommand1 = new SqlCommand("select PerMeslek, Avg(PerMaas) from Tbl_Personel group by PerMeslek",sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                chart2.Series["Vocation-Salary"].Points.AddXY(sqlDataReader1[0], sqlDataReader1[1]);
            }


            sqlConnection.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Graphics_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
