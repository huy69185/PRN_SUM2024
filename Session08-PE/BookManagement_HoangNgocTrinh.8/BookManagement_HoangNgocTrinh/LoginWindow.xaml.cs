using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BookManagement_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly UserService _userService = new();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ////mở màn hình MainWindow
            ////khai báo biến tạo object và render
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            //this.Hide(); //vì class login kế thừa từ class cha Window của OS, có sẵn hàm của cha là Hide() ẩn chính mình đi không render nữa
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            UserAccount user = _userService.AuthenticateUser(email, password);

            //==============Không check RoleID nhưng sai đề bài rồi==============================
            //if (user != null)
            //{
            //    // Login successful, open the main window
            //    MainWindow mainWindow = new MainWindow();
            //    mainWindow.Show();
            //    this.Close();
            //}
            //else
            //{
            //    // Show login failure message
            //    MessageBox.Show("Invalid email or password. Please try again.");
            //}

            //=======================Code đúng có check RoleID===============
            if (user != null)
            {
                if (_userService.IsAuthorizedRole(user))
                {
                    // Login successful and user is authorized
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    //Thông báo nếu sai RoleID
                    MessageBox.Show("You do not have permission to access this application.");
                }
            }
            else
            {
                //Thông báo login fail
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }
    }
}
