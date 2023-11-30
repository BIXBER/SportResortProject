using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace SportResort.Pages
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private bool ValidateInitials()
        {
            string initials = initialsTextBoxField.Text.Trim();
            if (string.IsNullOrEmpty(initials))
            {
                MessageBox.Show("Пожалуйста, введите ФИО.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string[] names = initials.Split(' ');
            foreach (string name in names)
            {
                if (string.IsNullOrWhiteSpace(name) || !char.IsUpper(name[0]))
                {
                    MessageBox.Show("Пожалуйста, введите ФИО с большой буквы и разделите их пробелами.\n\nПример: Иванов Иван Иванович",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }

            return true;
        }

        private bool ValidateUsername()
        {
            string username = usernameTextBoxField.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Пожалуйста, введите ник.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string usernamePattern = @"^[\w.@+-]+\Z";
            if (!Regex.IsMatch(username, usernamePattern))
            {
                MessageBox.Show("Пожалуйста, введите корректный ник.\n\nДопустимы только буквы, цифры и символы: @/./+/-/_", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        private bool ValidateEmail()
        {
            string email = emailTextBoxField.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Пожалуйста, введите email.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Пожалуйста, введите корректный email.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        private bool ValidatePassword()
        {
            string password = passwordPasswordBoxField.Password.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private bool ValidateGender()
        {
            if (genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите пол.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private string GetSelectedGender()
        {
            if (genderComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string genderTag = selectedItem.Tag as string;
                if (genderTag == "M")
                {
                    return "M";
                }
                else if (genderTag == "F")
                {
                    return "F";
                }
            }

            return string.Empty;
        }

        private void registrationButton_onClick(object sender, RoutedEventArgs e)
        {
            List<Func<bool>> validators = new List<Func<bool>>
            {
                ValidateInitials,
                ValidateUsername,
                ValidateEmail,
                ValidatePassword,
                ValidateGender,
            };

            bool isValid = validators.All(validator => validator());

            if (isValid)
            {

                try
                {
                    Users registrationObject = CreateRegistrationObject();
                    using (var dbContext = new SportResortEntities())
                    {
                        dbContext.Users.Add(registrationObject);
                        dbContext.SaveChanges();
                        MessageBox.Show($"Вы были успешно зарегистрированы в системе нашего магазина!", "Успешная регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService?.Navigate(new AuthorizationPage());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка рагистрации пользователя в системе." + ex.Message, "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }
        private Users CreateRegistrationObject()
        {
            string initials = initialsTextBoxField.Text.Trim();
            string[] names = initials.Split(' ');

            string lastName = names[0];
            string firstName = names[1];
            string patronymic = names[2];

            string username = usernameTextBoxField.Text.Trim();
            string email = emailTextBoxField.Text.Trim();
            string password = passwordPasswordBoxField.Password.Trim();

            string selectedGender = GetSelectedGender();

            Users registrationObject = new Users
            {
                last_name = lastName,
                first_name = firstName,
                patronymic = patronymic,
                username = username,
                email = email,
                passphrase = password,
                gender = selectedGender,
                role_id = 3,
            };

            return registrationObject;
        }
    }
}