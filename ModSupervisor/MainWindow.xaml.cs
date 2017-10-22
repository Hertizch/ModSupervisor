using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using ModPortalApi;

namespace ModSupervisor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DiscoverLocalMods();
        }

        private async void DiscoverLocalMods()
        {
            var modPortalApiClient = new ModPortalApiClient();

            await modPortalApiClient.GetModInfo("&namelist=rso-mod&namelist=boblibrary");

            if (modPortalApiClient.ApiData.Results == null) return;

            foreach (var result in modPortalApiClient.ApiData.Results)
            {
                Debug.WriteLine($"Title: {result.Title}");
            }
        }
    }
}
