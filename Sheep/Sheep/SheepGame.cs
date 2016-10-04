using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
namespace SheepGame 
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class SheepGame : Game 
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D sheepSheet;
        float time;
        float frameTime = 0.3f;
        int frameIndex;
        const int totalFrames = 3;
        int frameHeight = 32;
        int frameWidth = 32;

        public SheepGame() 
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() 
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() 
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            sheepSheet = Content.Load<Texture2D>("Graphics\\Sheep");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent() 
        { 
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LawnGreen);

            // TODO: Add your drawing code here

            time += (float)gameTime.ElapsedGameTime.TotalSeconds;
            while (time > frameTime) {
                // Play the next frame in the SpriteSheet
                frameIndex++;
                // reset elapsed time
                time = 0f;
            }
            if (frameIndex >= totalFrames) frameIndex = 1;
            Rectangle source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);
            Vector2 position = new Vector2(this.Window.ClientBounds.Width / 2, this.Window.ClientBounds.Height / 2);
            Vector2 origin = new Vector2(frameWidth / 2.0f, frameHeight);
            spriteBatch.Begin();
            
            // Draw the current frame.
            spriteBatch.Draw(sheepSheet, position, source, Color.White, 0.0f, origin, 1.0f, SpriteEffects.None, 0.0f);
            
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}