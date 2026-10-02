using System.Numerics;
using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé par la raquette à l'écran.</summary>
    static Rectangle RectangleRaquette()
    {
        return new Rectangle(positionRaquette.X, positionRaquette.Y, LARGEUR_RAQUETTE, HAUTEUR_RAQUETTE);
    }

    /// <summary>Déplace la raquette avec les flèches, sans sortir de la fenêtre.</summary>
    static void DeplacerRaquette(float dt)
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left) && positionRaquette.X > 0)
        {
            positionRaquette.X -=  VITESSE_RAQUETTE / 60;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Right) && (positionRaquette.X + LARGEUR_RAQUETTE) < LARGEUR)
        {
            positionRaquette.X += VITESSE_RAQUETTE / 60;
        }

    }

    /// <summary>Fait rebondir la balle si elle touche la raquette.</summary>
    static void RebondirSurRaquette()
    {
        if (vitesseBalle.Y > 0 && 
            positionBalle.Y + RAYON_BALLE * 2 >= positionRaquette.Y &&
            positionBalle.X >= positionRaquette.X &&
            positionBalle.X <= positionRaquette.X + LARGEUR_RAQUETTE)
        {
            vitesseBalle.Y *= -1;
        }
    }
}
