using System.Numerics;
using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
        positionBalle.X = positionRaquette.X + (LARGEUR_RAQUETTE / 2);
        positionBalle.Y = positionRaquette.Y - HAUTEUR_RAQUETTE + RAYON_BALLE;
    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            vitesseBalle.X += VITESSE_BALLE;
            vitesseBalle.Y += VITESSE_BALLE;
            etat = EtatJeu.Jeu;
        }
        
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        return false;
    }
}
