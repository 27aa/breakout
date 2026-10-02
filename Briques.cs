using Raylib_cs;
using System.Numerics;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé à l'écran par la brique (ligne, colonne).</summary>
    static Rectangle RectangleBrique(int ligne, int colonne)
    {
        float x = ESPACE_BRIQUES + colonne * (LARGEUR_BRIQUE + ESPACE_BRIQUES);
        float y = MARGE_HAUT_BRIQUES + ligne * (HAUTEUR_BRIQUE + ESPACE_BRIQUES);
        return new Rectangle(x, y, LARGEUR_BRIQUE, HAUTEUR_BRIQUE);
    }

    /// <summary>Casse la brique touchée par la balle, fait rebondir la balle et ajoute les points.</summary>
    static void CasserBriques()
    {
        //for (int i = 0; i < LIGNES_BRIQUES; i++)
        //{
        //    for (int j = 0; j < COLONNES_BRIQUES; j++)
        //    {
        //        if (positionBa)
        //        {
                    
        //        }
        //        briques[i, j] = true;
        //    }
        //}
    }

    /// <summary>Le nombre de briques encore présentes.</summary>
    static int CompterBriques()
    {
        return 0;
    }

    /// <summary>Dessine les briques encore présentes, une couleur par ligne.</summary>
    static void DessinerBriques()
    {
        for (int i = 0; i < LIGNES_BRIQUES; i++)
        {
            for (int j = 0; j < COLONNES_BRIQUES; j++)
            {
                if (briques[i, j])
                {

                    Rectangle rec = RectangleBrique(i, j);
                    Raylib.DrawRectangleRec(rec, couleursLignes[i]);
                }
            }
        }
    }
}
