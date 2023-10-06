using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Devcade;

namespace YourGameName // Replace "YourGameName" with your actual game name
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Rectangle windowSize;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            Input.Initialize();

            // Set window size or full screen based on your requirements
#if DEBUG
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
#else
            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();
#endif

            windowSize = GraphicsDevice.Viewport.Bounds;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load your game content here
            // Example: Load a texture
            // var texture = Content.Load<Texture2D>("fileNameWithoutExtension");
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();

            // Add your game logic here

            // Example: Check for player input
            if (Input.IsKeyPressed(Keys.Space))
            {
                // Perform some action when the Space key is pressed
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Add your drawing code here

            // Example: Draw a texture
            // _spriteBatch.Draw(texture, Vector2.Zero, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
