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
using Module3.ModelClasses;

namespace Module3.Pages
{
    
    public partial class LoginPage : Page
    {
        private Model1 model { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            model = new Model1();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            Accounts account = IsValidCredentials(login, password);

            if (account != null)
            {
                SetNewEnter(account);

                switch (account.RoleID)
                {
                    case 1:
                        MessageBox.Show("Вы успешно авторизовались");
                        this.NavigationService.Navigate(new AdminPage(model));
                        break;
                    case 2:
                        ZeroiseBadLoginTry(account);
                        MessageBox.Show("Вы успешно авторизовались");

                        if ((bool)account.NewUser)
                        {
                            this.NavigationService.Navigate(new UpdatePasswordPage(model, account));
                            break;
                        }
                        this.NavigationService.Navigate(new UserPage());
                        break;
                    default:
                        MessageBox.Show("Роль не найдена");
                        break;
                }
            }
        }

        private void SetNewEnter(Accounts account)
        {
            account.LastDateAuthorization = DateTime.Now.Date;

            try
            {
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ZeroiseBadLoginTry(Accounts account)
        {
            account.BadLoginTry = 0;

            try
            { 
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetDateInterval(DateTime lastautorizaation)
        {
            return (DateTime.Now - lastautorizaation).Days;
        }

        private void BlockAccount(Accounts account)
        {
            account.StatusID = 2;

            try
            {
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
        }

        private void AddTryBadLogin(Accounts account)
        {
            account.BadLoginTry += 1;

            try
            {
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (account.BadLoginTry == 3)
            {
                BlockAccount(account);
                return;
            }

            string text = "Вы ввели неверный пароль.\n" +
                          "Пожалуйста проверьте ещё раз введенные данные\n";

            text += account.RoleID != 1 ? $"Оставшиеся попытки входа {3 - account.BadLoginTry}" : "";

            MessageBox.Show(text);
        }

        private Accounts SearchAccount(string login, string password)
        {
            Accounts account = model.Accounts.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (account != null)
            {
                if (IsValidAccount(account))
                    return account;
            }
            else
            {
                account = model.Accounts.FirstOrDefault(x => x.Login == login);
                IsValidLogin(account); 
            }
            return null;
        }

        private bool IsValidAccount(Accounts accounts)
        {

            if (accounts != null)
            {
                if (accounts.RoleID == 1 && accounts.StatusID != 2)
                    return true;

                if (accounts.StatusID == 2)
                {
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                    return false;
                }

                if (GetDateInterval(accounts.LastDateAuthorization) >= 30)
                {
                    BlockAccount(accounts);
                    return false;
                }
            }
            return true;
        }

        private void IsValidLogin(Accounts accounts)
        {

            if (accounts != null)
            {
                if (accounts.StatusID == 2)
                {
                    MessageBox.Show("Вы заблокированы. Обратитесь к администратору");
                    return;
                }
                AddTryBadLogin(accounts);
                return;
            }
            MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные"); 
        }

        private Accounts IsValidCredentials(string login, string password)
        {
            if (String.IsNullOrWhiteSpace(login) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните поля Логин и Пароль");
                return null;
            }
            Accounts account = SearchAccount(login, password);
            return account;
        }
    }
}

