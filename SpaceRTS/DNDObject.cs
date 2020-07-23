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
	class DNDObject : UIObject
	{
		bool clicked = false;

		public override void Draw(GameTime gt, SpriteBatch sb)
		{
			base.Draw(gt, sb);
		}

		public override void HandleInput(InputHelper ih)
		{
			if (clickbox.Contains(ih.MousePosition) && ih.MouseLeftButtonDown())
			{
				clicked = true;
			}
			if (clicked)
			{
				if (!ih.MouseLeftButtonDown())
				{
					clicked = false;
				}
				else
					Position = ih.MousePosition;
			}
		}

		public override void Update(GameTime gt)
		{
			base.Update(gt);
		}
	}
}
