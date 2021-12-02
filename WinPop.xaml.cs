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
    /// Логика взаимодействия для WinPop.xaml
    /// </summary>
    public partial class WinPop : Window
    {
        public WinPop()
        {
            InitializeComponent();
            var msgList = Helper.GetContext().popular_group.ToList();
            СomboBoxPopular.ItemsSource = msgList;
            var gridmsg = Helper.GetContext().popular_messages.ToList();
            DataGridPopMesssage.ItemsSource = gridmsg;

        }

        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            
            DataGridPopMesssage.ItemsSource = null;
        }

        private void СomboBoxPopular_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var popgroup = СomboBoxPopular.SelectedItem as popular_group;
            DataGridPopMesssage.ItemsSource = Helper.GetContext().popular_messages.Where(x => x.popular_group.Content == popgroup.Content || popgroup.Content == "Все группы").ToList();


        }
    }
}
