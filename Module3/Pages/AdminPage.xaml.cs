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
    public partial class AdminPage : Page
    {
        private Model1 model { get; set; }
        public AdminPage(Model1 model)
        {
            InitializeComponent();
            this.model = model;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddUpdateAccountsPage(model));
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        { 
            if (accountsDataGrid.SelectedItems.Count > 0)
            {
                Accounts selectedAcount = accountsDataGrid.SelectedItem as Accounts;

                if (selectedAcount != null)
                {
                    this.NavigationService.Navigate(new AddUpdateAccountsPage(model, selectedAcount));
                }
            }
        }
 
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
 
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        { 
            Accounts selectedAcount = accountsDataGrid.SelectedItem as Accounts;

            var result = MessageBox.Show($"Вы точно хотите удалить элемент c ID {selectedAcount.ID}?",
"Подтверждение",
                                         MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                model.Accounts.Remove(selectedAcount);

                try
                {
                    model.SaveChanges();

                    MessageBox.Show($"Пользователь с ID - {selectedAcount.ID} удалён");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                LoadDataInCollectionViewSource();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataInCollectionViewSource();
        }
 
        private void LoadDataInCollectionViewSource()
        {
            (Resources["accountsViewSource"] as CollectionViewSource).Source = model.Accounts.ToList();
        }
    }
}
