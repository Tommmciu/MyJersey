using System.Windows;
using System.Windows.Controls;
using MyJersey.GUI.Pages;
using MyJersey.Service.Interfaces;

namespace MyJersey.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly JerseyList _jerseyList;
        private readonly TeamList _teamList;

        public MainWindow(JerseyList jerseyList, TeamList teamList)
        {
            _jerseyList = jerseyList;
            _teamList = teamList;
            InitializeComponent();
        }

        private void JerseyPanel_OnChecked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(_jerseyList);
        }

        private void TeamPanel_OnChecked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(_teamList);
        }
    }
}