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
    /// Логика взаимодействия для User_page.xaml
    /// </summary>
    public partial class User_page : Window
    {
        public User_page()
        {
            InitializeComponent();

            AppContext app = new AppContext();
            List<User> users = app.Users.ToList();
            ListUsers.ItemsSource = users;
           
        }
    }
}
