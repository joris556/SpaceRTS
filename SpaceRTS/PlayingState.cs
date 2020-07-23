using System;
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
		PlayingField mainScreen, secondScreen;

        public PlayingState() : base()
        {
            gameObjects = new List<GameObject>();
            mainScreen = new Town();
            secondScreen = new Pit();

            Switch();
            Switch();
        }

        public override void Update(GameTime gt)
        {
			mainScreen.Update(gt);
			secondScreen.Update(gt);
		}

		public override void HandleInput(InputHelper ih)
        {
			mainScreen.HandleInput(ih);
			if (ih.KeyPressed(Keys.K))
			{
				Switch();
			}
		}

        public override void Draw(GameTime gt, SpriteBatch sb)
        {
			mainScreen.Draw(gt, sb);
			secondScreen.Draw(gt, sb);
		}

		public void Switch()
		{
			PlayingField temp = mainScreen;
			mainScreen = secondScreen;
			secondScreen = temp;
			mainScreen.MainScreen = true;
			secondScreen.MainScreen = false;
			mainScreen.Switch();
			secondScreen.Switch();
		}
    }
}
