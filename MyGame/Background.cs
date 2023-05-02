using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Background : GameObject
    {
        private const float Scroll = 0.2f;
        private readonly Sprite _sprite = new Sprite();
        private readonly Sprite _sprite2 = new Sprite();
        public Background()
        {
            _sprite.Texture = Game.GetTexture("Resources/background.png");
            _sprite.Position = new Vector2f(0, 0);
            _sprite2.Texture = Game.GetTexture("Resources/background.png");
            _sprite2.Position = new Vector2f(800, 0);
        }

        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
            Game.RenderWindow.Draw(_sprite2);
        }
        public override void Update(Time elapsed)
        {
            int msElapsed = elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;
            Vector2f pos2 = _sprite2.Position;
            _sprite.Position = new Vector2f(pos.X - Scroll * msElapsed, pos.Y);
            _sprite2.Position = new Vector2f(pos2.X - Scroll * msElapsed, pos2.Y);
            if (pos.X < _sprite.GetGlobalBounds().Width * -1)
            {
                GameScene scene = (GameScene)Game.CurrentScene;
                _sprite.Position = new Vector2f(800, 0);
            }
            if (pos2.X < _sprite2.GetGlobalBounds().Width * -1)
            {
                GameScene scene = (GameScene)Game.CurrentScene;
                _sprite2.Position = new Vector2f(800, 0);
            }
        }

    }
}
