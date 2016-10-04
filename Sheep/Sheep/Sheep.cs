using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SheepGame
{
    public class Sheep
    {
        public Texture2D sheepTexture;
        public Vector2 position;
        public bool active;

        // Get the width of the sheep
        public int Width
        {
            get { return sheepTexture.Width; }
        }

        // Get the height of the sheep
        public int Height
        {
            get { return sheepTexture.Height; }
        }

        public void Initialize(Texture2D texture, Vector2 initPosition)
        {
            sheepTexture = texture;
            position = initPosition;
            active = true;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sheepTexture, position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}