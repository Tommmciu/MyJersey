using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MyJersey.Entities;
using MyJersey.GUI.ViewModels;
using MyJersey.Service.Interfaces;

namespace MyJersey.GUI.Pages
{
    /// <summary>
    /// Interaction logic for JerseyList.xaml
    /// </summary>
    public partial class JerseyListPage : Page
    {
        public JerseyListPage(IJerseyService jerseyService)
        {
            InitializeComponent();
            var jerseys = jerseyService.GetView().ToList();
            var viewModel =new ObservableCollection<JerseyViewModel>() ;
            jerseys.ForEach(jersey => viewModel.Add(new JerseyViewModel(jersey)));
            JerseyList.ItemsSource = jerseys;
        }
    }
}
