using System;
using System.Collections;
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

namespace A2_UF3_AutenticacióFirebase
{
    /// <summary>
    /// Lógica de interacción para BDD.xaml
    /// </summary>
    public partial class BDD : Page
    {
        public BDD()
        {
            InitializeComponent();
            LoadCharacters();
        }
        public CharacterService characterService = new CharacterService();
        private async Task LoadCharacters()
        {
            var characters = await characterService.GetCharacters();
            lstCharacters.ItemsSource = characterService.GetAllCharacters();
        }

        private async void btnCreate_Click(object sender, RoutedEventArgs e)
        {

            Character character = new Character(cName.Text, cDesc.Text, cShow.Text, cDate.Text, cImg.Text);
            await characterService.AddCharacter(character);
        }
    }
}
