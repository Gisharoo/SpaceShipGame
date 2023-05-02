using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameEngine;

namespace MyGame
{
    class GameOverScene : Scene
    {
        public GameOverScene(int score)
        {
            GameOverMessage gameOverMessage = new GameOverMessage(score);
            AddGameObject(gameOverMessage);
        }
    }
}
