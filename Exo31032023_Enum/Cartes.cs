using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exo31032023_Enum.Cartes;

namespace Exo31032023_Enum
{
    struct Cartes
    {   
        public Valeurs Valeur;

        public enum Valeurs
        {
            deux = 2,
            trois,
            quatre,
            cinq,
            six,
            sept,
            huit,
            neuf,
            dix,
            Valet,
            Dame,
            Roi,
            As

        }   
        public Couleurs Couleur;
        public enum Couleurs
        {
            Coeur ,
            Carreau,
            Pique,
            Trefle
        }
    }


}
