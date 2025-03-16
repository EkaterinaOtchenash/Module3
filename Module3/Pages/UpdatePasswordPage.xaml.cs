using Module3.ModelClasses;
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

namespace Module3.Pages
{
    public partial class UpdatePasswordPage : Page
    {
        private Accounts account { get; set; }
        private Model1 model { get; set; }

        public UpdatePasswordPage(Model1 model, Accounts account)
        {
            InitializeComponent();
            this.model = model;
            this.account = account;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            string psbox1text = PasswordBox1.Password;
            string psbox2text = PasswordBox2.Password;

            if (IsValidData(psbox1text, psbox2text))
            {
                account.Password = psbox1text;

                account.NewUser = false;

                try
                {
                    model.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Пароль успешно изменён");

                this.NavigationService.Navigate(new UserPage());
            }
        }

        private bool IsValidData(string password1, string password2)
        { 
            if (String.IsNullOrWhiteSpace(password1) && String.IsNullOrWhiteSpace(password2))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            } 
            if (password1 == password2 && account.Password != password1)
                return true;

            MessageBox.Show("Пароли должны быть одинаковыми и не совпадать с предыдущим паролем");
            return false;
        }
    }
}
