using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        private void makeConnection()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                try
                {
                    string connectionStringMaster = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringMaster"].ConnectionString;
                    connection = new SqlConnection(connectionStringMaster);
                    connection.Open();
                    string commandCREATE = "CREATE DATABASE KURSACH";
                    SqlCommand command = new SqlCommand(commandCREATE, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("БД создана заново");
                    connection.Close();
                    string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    commandCREATE = "create table ADDRESS (ADDRESS_ID integer  identity(1, 1) constraint PK_ADDRESS  primary key,STREET  nvarchar(64) not null,HOUSE  nvarchar(5)   not null,HOUSING nvarchar(5),FLAT integer )";
                    SqlCommand commandc = new SqlCommand(commandCREATE, connection);
                    if (commandc.ExecuteNonQuery() == 1)
                        MessageBox.Show("Выполнилось");
                }
                catch
                {
                    MessageBox.Show("Работа с базой данных невозможна");
                    return;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            makeConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ADDRESS", connection);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "address");
                datarid.ItemsSource = ds.Tables["address"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            makeConnection();
            try
            {
                string commandAdd = "INSERT INTO ADDRESS values ('Орды', '5', '9', 100)";
                SqlCommand command = new SqlCommand(commandAdd, connection);
                if(command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Выполнилось");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            makeConnection();
            try
            {
                string commandDel = "DELETE FROM ADDRESS WHERE STREET='Орды'";
                SqlCommand command = new SqlCommand(commandDel, connection);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Выполнилось");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
    }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            makeConnection();
            try
            {
                string commandDel = "UPDATE ADDRESS SET HOUSING = 8 WHERE STREET='Орды'";
                SqlCommand command = new SqlCommand(commandDel, connection);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Выполнилось");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            makeConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ADDRESS WHERE STREET='Орды'", connection);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "address");
                datarid.ItemsSource = ds.Tables["address"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            makeConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("exec getAddresses", connection);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "address");
                datarid.ItemsSource = ds.Tables["address"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            makeConnection();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            try
            {
                command.CommandText = "INSERT INTO ADDRESS VALUES ('Будника', '10', '1', 4)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO ADDRESS VALUES ('Будника', '10', '2', 182)";
                command.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Транзакция прошла успешно");
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Lower_Click(object sender, RoutedEventArgs e)
        {
            if (!datarid.Items.IsEmpty)
            {
                
                    if (datarid.SelectedIndex < datarid.Items.Count - 1)
                        datarid.SelectedIndex++;
            }
        }

        private void Higher_Click(object sender, RoutedEventArgs e)
        {
            if (!datarid.Items.IsEmpty)
            {
                if (datarid.SelectedIndex > 0)
                    datarid.SelectedIndex--;
            }
        }
    }
}
