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
using Firebase.Auth;
using Firebase.Auth.UI;

namespace A2_UF3_AutenticacióFirebase
{
    /// <summary>
    /// Lógica de interacción para EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : Window
    {
        public EditorWindow()
        {
            InitializeComponent();
        }
        private void SignOutClick(object sender, RoutedEventArgs e)
        {
            FirebaseUI.Instance.Client.SignOut();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
