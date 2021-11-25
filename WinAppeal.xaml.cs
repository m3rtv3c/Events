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

namespace Events
{
    /// <summary>
    /// Логика взаимодействия для WinAppeal.xaml
    /// </summary>
    public partial class WinAppeal : Window
    {
        public WinAppeal()
        {
            InitializeComponent();   
            var fedList = Helper.GetContext().federal_districts.ToList();
            ComboBoxFederal.ItemsSource = fedList;
            var catList = Helper.GetContext().message_categories.ToList();
            ComboBoxCategories.ItemsSource = catList;

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ButtonAppeal_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxMessage.Text.Length >= 0 && ComboBoxCategories.SelectedIndex >= 0 && ComboBoxFederal.SelectedIndex >= 0)
            {
                ErrorLog.Text = "Обращение успешно подано";
                if (ErrorLog.Text == "Обращение успешно подано")
                {
                    using (EventsEntities db = new EventsEntities())
                    {
                        user user = new user();
                        user.first_name = TextBoxFirstName.Text;
                        user.second_name = TextBoxMiddleName.Text;
                        user.Patronymic = TextBoxLastName.Text;
                        user.Telephone = TextBoxPhone.Text;
                        user.Email = TextBoxEmail.Text;
                        user.Age = !string.IsNullOrEmpty(TextBoxAge.Text) ? int.Parse(TextBoxAge.Text) : 0;
                        federal_districts federal = db.federal_districts.FirstOrDefault(x => x.federal_districts1 == ComboBoxFederal.Text);
                        user.id_user_federal_districts = federal.Id_federal_districts;
                        db.user.Add(user);
                        db.SaveChanges();
                        ButtonAppeal.IsEnabled = false;
                        MessageBox.Show("Обращение успешно подано", "Обращение", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow main = new MainWindow();
                        main.Show();
                        this.Close();
                    }

                }
                else
                {
                    ButtonAppeal.IsEnabled = true;
                }
            }
            else
            {
                ErrorLog.Text = "Не заполнены обязательный данные";
            }
        }


    }
}
    

