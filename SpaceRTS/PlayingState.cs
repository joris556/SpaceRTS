﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SpaceRTS
{
    class PlayingState : GameState
    {
        List<GameObject> gameObjects;

        public PlayingState() : base()
        {
            gameObjects = new List<GameObject>();
        }

        public override void Update(GameTime gt)
        {
            foreach (GameObject g in gameObjects)
                g.Update(gt);
        }

        public override void HandleInput(InputHelper ih)
        {
            foreach (GameObject g in gameObjects)
                g.HandleInput(ih);
        }

        public override void Draw(GameTime gt, SpriteBatch sb)
        {
            foreach (GameObject g in gameObjects)
                g.Draw(gt, sb);
        }
    }
}
