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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportResort.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void transitToRegistrationButton_onClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new RegistrationPage());
        }

        private void loginButton_onClick(object sender, RoutedEventArgs e)
        {
            string enteredUsername = loginTextBoxField.Text;
            string enteredPassword = passwordPasswordBoxField.Password;

            using (var dbContext = new SportResortEntities())
            {
                var user = dbContext.Users.FirstOrDefault(
                    u =>
                    u.username == enteredUsername &&
                    u.passphrase == enteredPassword);
                if (user != null)
                {
                    MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

                    NavigationService?.Navigate(new MainPage((short)user.role_id));


                    MessageBox.Show("Добро пожаловать в магазин Sport Resort, мы рады приветствовать Вас!", "Успешный вход");
                }
                else
                {
                    MessageBox.Show("Введён неверный логин или пароль. Попробуйте ещё раз!", "Неудачная авторизация");
                }
            }
        }
    }
}
