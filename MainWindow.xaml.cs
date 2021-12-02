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

namespace Events
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var listEvents = Helper.GetContext().events.ToList();
            ComboBoxEvents.ItemsSource = listEvents;

        }

        private void ButtonNewMessage_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBlockEventsStatus.Text))
            {
                if (TextBlockEventsStatus.Text == "текущее")
                {
                    WinAppeal winFilingAppeal = new WinAppeal();
                    winFilingAppeal.EventName.Text = TextBlockEvents.Text;
                    winFilingAppeal.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Подача обращение не удалась", "Подача обращения", MessageBoxButton.OK);
                }
            }
        }

        private void ComboBoxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectEvent = ComboBoxEvents.SelectedItem as events;
            TextBlockEvents.Text = selectEvent.Name;
            TextBoxEventDescription.Text = selectEvent.Description;

            DateTime dateTimeNow = DateTime.Now;

            if (dateTimeNow > selectEvent.Datatime_end)
            {
                TextBlockEventsStatus.Text = "прошедшее";
            }
            else
            {
                if (dateTimeNow > selectEvent.Datatime_begin && dateTimeNow < selectEvent.Datatime_end)
                {
                    TextBlockEventsStatus.Text = "текущее";
                }
                else TextBlockEventsStatus.Text = "предстоящее";
            }
        }

        private void ButtonPopularMessages_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (TextBlockEventsStatus.Text == "текущее" || TextBlockEventsStatus.Text == "прошедшее")
                {
                    WinPop winpop = new WinPop();
                    winpop.TextBlockEvent.Text = TextBlockEvents.Text;
                    this.Close();
                    winpop.Show();
                }
                else
                {
                    MessageBox.Show("Просмотр популярных сообщения доступна только для прошедших, или текущих мероприятий", "Популярные сообщения", MessageBoxButton.OK, MessageBoxImage.Information);
                }
        }
            catch
            {
                MessageBox.Show("Просмотр популярных сообщения доступна только для прошедших, или текущих мероприятий", "Популярные сообщения", MessageBoxButton.OK, MessageBoxImage.Information);
            }
}
    }
}



