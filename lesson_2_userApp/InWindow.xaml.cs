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

namespace lesson_2_userApp
{
    /// <summary>
    /// Логика взаимодействия для InWindow.xaml
    /// </summary>
    public partial class InWindow : Window
    {
        public InWindow()
        {
            InitializeComponent();
            
            
        }

        private void Button_In_Click(object sender, RoutedEventArgs e)
        {
            string login = In_login.Text.Trim();
            string password = In_password.Password.Trim();
            if (login.Length < 5)
            {
                In_login.ToolTip = "Это поле должно содержать миним 6 символов";
                In_login.Background = Brushes.Red;
            }
            else if (password.Length < 5)
            {
                In_password.ToolTip = "Это поле должно содержать миним 6 символов";
                In_password.Background = Brushes.Red;
            }
            else
            {
                In_login.ToolTip = null;
                In_login.Background = Brushes.Transparent;
                In_password.ToolTip = null;
                In_password.Background = Brushes.Transparent;
                

                User InUser = null;
                using(AppContext context = new AppContext())
                {
                    InUser = context.Users.Where(b => b.login == login && b.password == password).FirstOrDefault();
                }

                if (InUser == null)
                {
                    MessageBox.Show("Что-то пошло не так!");
                }
                else
                {
                    MessageBox.Show("Добро пожаловать!");
                    User_page user_page = new User_page();
                    user_page.Show();
                    Hide();
                }
                    



            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Hide();
        }
    }
}
