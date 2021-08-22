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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lesson_2_userApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation dAn = new DoubleAnimation();
            dAn.From = 0;
            dAn.To = 450;
            dAn.Duration = TimeSpan.FromSeconds(4);
            RegButton.BeginAnimation(Button.WidthProperty, dAn);

            db = new AppContext();

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TB_login.Text.Trim();
            string password = PB_password.Password.Trim();
            string password_2 = PB_dpassword.Password.Trim();
            string email = TB_email.Text.Trim().ToLower();
            if (login.Length < 5)
            {
                TB_login.ToolTip = "Это поле должно содержать миним 6 символов";
                TB_login.Background = Brushes.Red;
            }
            else if (password.Length < 5)
            {
                PB_password.ToolTip = "Это поле должно содержать миним 6 символов";
                PB_password.Background = Brushes.Red;
            }
            else if (password_2 != password)
            {
                PB_dpassword.ToolTip = "Это поле должно содержать миним 6 символов";
                PB_dpassword.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TB_email.ToolTip = "Это поле должно содержать миним 6 символов и иметь символы @ и .";
                TB_email.Background = Brushes.Red;
            }
            else
            {
                TB_login.ToolTip = null;
                TB_login.Background = Brushes.Transparent;
                PB_password.ToolTip = null;
                PB_password.Background = Brushes.Transparent;
                PB_dpassword.ToolTip = null;
                PB_dpassword.Background = Brushes.Transparent;
                TB_email.ToolTip = null;
                TB_email.Background = Brushes.Transparent;
                

                User user = new User(login, password, email);
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Вы успешно зарегистрировались");

                InWindow In = new InWindow();
                In.Show();
                Hide();

            }

        }

        private void Button_input_Click(object sender, RoutedEventArgs e)
        {
            InWindow In = new InWindow();
            In.Show();
            Hide();
        }
    }
}
