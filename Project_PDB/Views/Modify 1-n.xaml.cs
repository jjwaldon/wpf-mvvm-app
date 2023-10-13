using Project_PDB.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Project_PDB.Views
{

    public partial class Modify_1_n : UserControl
    {
        ShopEntities db;
        public Modify_1_n()

        {
            InitializeComponent();
        }

        private void Mod_Loaded(object sender, RoutedEventArgs e)
        {
            db = new ShopEntities();
            Mod1n.ItemsSource = db.Orders.ToList();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ShopEntities"].ConnectionString;
            if (connectionString.ToLower().StartsWith("metadata="))
            {
                System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder efBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(connectionString);
                connectionString = efBuilder.ProviderConnectionString;
            }

            if (comboBox.SelectedIndex == 0)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "UPDATE Orders SET AssignedEmployee = " + CustOrdNum.Text + " WHERE CustomerOrderNumber = " + Input.Text;

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

                Mod_Loaded(sender, e);

            }

            if (comboBox.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "UPDATE Orders SET OrderAmount = " + CustOrdNum.Text + " WHERE CustomerOrderNumber = " + Input.Text;

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

                Mod_Loaded(sender, e);

            }

            if (comboBox.SelectedIndex == 2)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "UPDATE Orders SET AccountNumber = " + CustOrdNum.Text + " WHERE CustomerOrderNumber = " + Input.Text;

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

                Mod_Loaded(sender, e);

            }

            if (comboBox.SelectedIndex == 3)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "UPDATE Orders SET TransactionDate = @CustOrdNum   WHERE  CustomerOrderNumber  = @Input ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@CustOrdNum", CustOrdNum.Text));
                cmd.Parameters.Add(new SqlParameter("@Input", Input.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                Mod_Loaded(sender, e);

            }

        }



    }
}
