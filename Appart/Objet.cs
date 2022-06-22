using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appart
{
    class Objet
    {
        public string nom;
        public string zone;
        public string description;
        public string statut1;
        public string statut2;
        public Objet(string nom, string description, string zone, string statut1, string statut2)
        {
            this.nom = nom;
            this.description = description;
            this.zone = zone;
            this.statut1 = statut1;
            this.statut2 = statut2;
        }

    }
}
