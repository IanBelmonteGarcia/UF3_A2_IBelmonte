using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_UF3_AutenticacióFirebase
{
    public class Character
    {
        private string nom;
        private string descripcio;
        private string serie;
        private string data;
        private string url;
        public string Nom { get { return nom; } set {  nom = value; } }
        public string Descripcio { get {  return descripcio; } set {  descripcio = value; } }
        public string Serie { get {  return serie; } set {  serie = value; } }
        public string Data { get { return data; } set { data = value; } }
        public string Url { get { return url; } set { url = value; } }
        public Character(string nom, string descripcio, string serie, string data, string url)
        {
            this.nom = nom;
            this.descripcio = descripcio;
            this.serie = serie;
            this.data = data;
            this.url = url;
        }

    }
}
