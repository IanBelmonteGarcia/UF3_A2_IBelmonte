using Firebase.Auth;
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
using Firebase.Auth.UI;
using Firebase.Database;
using Firebase.Auth.Providers;
using Firebase.Auth.UI.Pages;

namespace A2_UF3_AutenticacióFirebase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FirebaseUI.Instance.Client.SignOut();
            FirebaseUI.Instance.Client.AuthStateChanged += this.AuthStateChanged;
        }

        private void AuthStateChanged(object sender, UserEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                if (e.User == null)
                {
                    //await FirebaseUI.Instance.Client.SignInAnonymouslyAsync();
                    this.Frame.Navigate(new Login());
                }
                else if (e.User.IsAnonymous)
                {
                    this.Frame.Navigate(new Login());
                }
                else if ((this.Frame.Content == null || this.Frame.Content.GetType() != typeof(BDD)))
                {
                    this.Frame.Navigate(new BDD());
                }
            });
            
        }
    }
}
