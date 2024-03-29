﻿using Firebase.Auth.UI;
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
            firebaseClient = ClientCreator.GetFirebaseClient(FirebaseDatabaseUrl, "2Ex9nEJ9vIcm4j8gB9SNN5e0Hb33");
        }
        public async Task AddCharacter(Character character)
        {
            await firebaseClient
            .Child("Characters")
            .PostAsync(character);
        }
        public async Task<List<Character>> GetCharacters()
        {
            var characters = await firebaseClient.Child("Characters").OnceAsync<Character>();
            foreach (var character in characters)
            {
                character.Object.Nom = character.Key;
            }
            return characters.Select(firebaseObject => firebaseObject.Object).ToList();
        }
        public List<Character> GetAllCharacters() 
        {
            return GetCharacters().Result;
        }
    }
}
