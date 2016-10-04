using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SheepGame
{
    public class Sheep
    {
        public Texture2D texture;
        public Vector2 Position;
        public bool active;

        public Sheep()
        {

        }

        public void Initialize(Texture2D texture, Vector2 position)
        {

            PlayerTexture = texture;
            // Set the starting position of the player around the middle of the screen and to the back
            Position = position;
            
            // Set the player to be active
            Active = true;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}