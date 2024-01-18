using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_UF3_AutenticacióFirebase
{
    public static class ClientCreator
    {
        public static FirebaseClient GetFirebaseClient(string url, string secret = null)
        {
            return new FirebaseClient(url, new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(secret)
            });
        }
    }
}
