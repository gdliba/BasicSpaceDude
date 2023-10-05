using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BasicSpaceDude
{
    class Background
    {
        // Class Variables
        private Texture2D Art;

        // Class Constructors
        public Background(Texture2D tex)
        {
            Art = tex;
        }

        // Class Methods
        public virtual void DrawMe(SpriteBatch sBatch)
        {
            sBatch.Draw(Art, Vector2.Zero, Color.White);
        }

    }

}
