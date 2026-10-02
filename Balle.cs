using System.Numerics;
using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
        positionBalle.X = positionRaquette.X + (LARGEUR_RAQUETTE / 2);
        positionBalle.Y = positionRaquette.Y - HAUTEUR_RAQUETTE + RAYON_BALLE /2;
    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            vitesseBalle.X += VITESSE_BALLE / 60;
            vitesseBalle.Y += VITESSE_BALLE / 60;
            etat = EtatJeu.Jeu;
        }
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
        positionBalle.X += vitesseBalle.X;
        positionBalle.Y += vitesseBalle.Y;
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
        if (positionBalle.X <= 0 || positionBalle.X + (RAYON_BALLE * 2) >= LARGEUR)
        {
            vitesseBalle.X = -vitesseBalle.X;
        }
        if (positionBalle.Y <= 0)
        {
            vitesseBalle.Y = -vitesseBalle.Y;
        }
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        return false;
    }
}
