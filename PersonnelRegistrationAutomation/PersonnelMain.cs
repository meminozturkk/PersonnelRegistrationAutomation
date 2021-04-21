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
    public partial class PersonnelMain : Form
    {
        bool marry,marryornot;

        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonelVerıTabanı;Integrated Security=True");
        public PersonnelMain()
        {
            InitializeComponent();
        }

        private void PersonnelMain_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVerıTabanıDataSet.Tbl_Personel);
        }// List
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",sqlConnection);

            sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CombCity.Text);
            sqlCommand.Parameters.AddWithValue("@p4", TxtSalary.Text);
            sqlCommand.Parameters.AddWithValue("@p5", marry);
            sqlCommand.Parameters.AddWithValue("@p6", TxtVocation.Text);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Registration Saved");
            Clear();
        }//Personnel Save

     
        private void RdMarried_CheckedChanged_1(object sender, EventArgs e)
        {
            marry = true;
        }

        private void RdUnmarried_CheckedChanged(object sender, EventArgs e)
        {
            marry = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            CombCity.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            TxtSalary.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            TxtVocation.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
            marryornot= Convert.ToBoolean(dataGridView1.Rows[chosen].Cells[5].Value);
            if (marryornot==true)
            {
                RdMarried.Checked = true;
            }
            else if (marryornot==false)
            {
                RdUnmarried.Checked = true;
            }
        }//Cell Double Click

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from Tbl_Personel where Perid=@d1",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@d1", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Registration Deleted");
            Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Personel Set PerAd=@u1 ,PerSoyad=@u2 ,PerSehir=@u3 ,PerMaas=@u4 ,PerDurum=@u5 ,PerMeslek=@u6 where Perid=@u7",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@u1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@u2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@u3", CombCity.Text);
            sqlCommand.Parameters.AddWithValue("@u4", TxtSalary.Text);
            sqlCommand.Parameters.AddWithValue("@u5", marry);
            sqlCommand.Parameters.AddWithValue("@u6", TxtVocation.Text);
            sqlCommand.Parameters.AddWithValue("@u7", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
       
            sqlConnection.Close();
            MessageBox.Show("Personnel Updated");
            Clear();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
        }

        private void BtnGraphic_Click(object sender, EventArgs e)
        {
            Graphics graphics = new Graphics();
            graphics.Show();
        }

        private void PersonnelMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Clear()
        {
            TxtName.Text = "";
            TxtSurname.Text = "";
            CombCity.Text = "";
            TxtSalary.Text = "";
            TxtVocation.Text = "";
            TxtId.Text = "";
            RdMarried.Checked = false;
            RdUnmarried.Checked = false;
            TxtName.Focus();
        }//clear methot
    }
}
