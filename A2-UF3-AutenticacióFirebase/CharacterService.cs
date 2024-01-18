using Firebase.Auth.UI;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_UF3_AutenticacióFirebase
{
    public class CharacterService
    {
        private const string FirebaseDatabaseUrl = "https://provadam-15e08-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly FirebaseClient firebaseClient;
        public CharacterService()
        {
            firebaseClient = new FirebaseClient(FirebaseDatabaseUrl);
        }
        public async Task AddStudent(Character character)
        {
            await firebaseClient
            .Child("Characters")
            .PostAsync(character);
        }
    }
}
