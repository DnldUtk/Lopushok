using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;


namespace Lopushok
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        DBConnect DB = new DBConnect();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            table.Rows.Clear();
            var loginUser = textBox_login.Text;
            var passwordUser = passwordBox_password.Password;

            string QueryString = $"select id_user, login, password, isUser, isAdmin, isMaster from authoriz where login ='{loginUser}' and password ='{passwordUser}'";
            SqlCommand command = new SqlCommand(QueryString, DB.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (textBox_login.Text.Length > 0)
            {
                if (passwordBox_password.Password.Length > 0)
                {
                    if (table.Rows.Count == 1)
                    {
                        var user = new CheckUsers(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]), Convert.ToBoolean(table.Rows[0].ItemArray[4]), Convert.ToBoolean(table.Rows[0].ItemArray[5]));
                        if (user.isUser == true)
                        {
                            MessageBox.Show("Вы успешно вошли как Пользователь!");
                            Manager.MainFrame.Navigate(new MainPage(user));
                        }
                        else
                        {
                            if (user.isAdmin == true)
                            {
                                MessageBox.Show("Вы успешно вошли как Администратор!");
                                Manager.MainFrame.Navigate(new MainPage(user));
                            }
                            else
                            {
                                if (user.isMaster == true)
                                {
                                    MessageBox.Show("Вы успешно вошли как Мастер смены!");
                                    Manager.MainFrame.Navigate(new MainPage(user));
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Неверно введен логин или пароль!");

                }
                else { MessageBox.Show("Введите пароль!"); }

            }
            else { MessageBox.Show("Введите логин!"); }
        }
    }
}
