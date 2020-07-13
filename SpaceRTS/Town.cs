using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceRTS
{
	class Town : PlayingField
	{

		public Town() : base()
		{
			GameObjects = new List<GameObject>();
		}

		public override void Update(GameTime gt)
		{
			base.Update(gt);
		}

		public override void HandleInput(InputHelper ih)
		{
			base.HandleInput(ih);
		}

		public override void Draw(GameTime gt, SpriteBatch sb)
		{
			base.Draw(gt, sb);
		}
	}
}
