﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace BasicSpaceDude
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static readonly Random RNG = new Random();

        // Class Variables
        Background bg;

        // Create a variable called "dudes" that is an array (collection) of
        // variables of type FloatyDude
        FloatyDude[] dudes;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Specify that dudes has space for 100 dudes
            dudes = new FloatyDude[100];

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            bg = new Background(Content.Load<Texture2D>("starfield"));

            Vector2 startPos = new Vector2(GraphicsDevice.Viewport.Bounds.Center.X + RNG.Next(-100, 100),
                                                    GraphicsDevice.Viewport.Bounds.Center.Y + RNG.Next(-100, 100));
            Vector2 startVel = new Vector2((float)(RNG.NextDouble() * 2) - 1,
                                                    (float)(RNG.NextDouble() * 2) - 1);
            dudes[0] = new FloatyDude(Content.Load<Texture2D>("dude0"), startPos, startVel);
        }

        protected override void Update(GameTime gameTime)
        {
            dudes[0].UpdateMe(GraphicsDevice.Viewport.Bounds);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            bg.DrawMe(_spriteBatch);

            dudes[0].DrawMe(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}