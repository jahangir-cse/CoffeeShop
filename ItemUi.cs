using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class ItemUi : Form
    {
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try {
                //INSERT INTO Items(Name, Price) values('Cold', 100)
                string connectionString = @"Server=MAHFUZ; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"INSERT INTO Items(Name,Price) values ('" + nameTextBox.Text + "'," + priceTextBox.Text + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("saved");
                }
                else
                {
                    MessageBox.Show("Not saved");
                }
                sqlConnection.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try {
                string connectionString = @"Server=MAHFUZ; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"select *from Items";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    showDataGridView.DataSource = null;
                    MessageBox.Show("Data not found!");
                }
                sqlConnection.Close();
            }
            catch(Exception exception)
            {
               

                //sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show(exception.Message);
            }
            //select* from Items
            


        }
           

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=MAHFUZ; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"delete from Items where Id=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {


                //sqlCommand.ExecuteNonQuery();

                MessageBox.Show(exception.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=MAHFUZ; Database=CoffeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"update Items set Name='"+nameTextBox.Text+"',Price="+priceTextBox.Text+" where Id=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception exception)
            {


                //sqlCommand.ExecuteNonQuery();

                MessageBox.Show(exception.Message);
            }
        }
    }
}
