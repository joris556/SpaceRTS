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
	class UIObject
	{
		protected Vector2 position;
		protected Texture2D sprite;
		protected Rectangle clickbox, spritebox;
		protected float rotation;
		protected bool visible = true;
		protected Vector2 origin;
		protected bool mainScreen = true;



		public Vector2 Position { get => position; set { position = value; clickbox.X = (int)position.X; clickbox.Y = (int)position.Y; } }
		public Texture2D Sprite { get => sprite; set => sprite = value; }
		public Rectangle Clickbox { get => clickbox; set => clickbox = value; }
		public Rectangle Spritebox { get => spritebox; set => spritebox = value; }
		public bool Visible { get => visible; set => visible = value; }
		public Vector2 Origin { get => origin; set => origin = value; }
		public float Rotation { get => rotation; set => rotation = value; }
		public bool MainScreen { get => mainScreen; set => mainScreen = value; }

		public UIObject()
		{
			position = position + Constants.POffset();
		}

		public virtual void Update(GameTime gt)
		{

		}

		public virtual void HandleInput(InputHelper ih)
		{

		}

		public virtual void Draw(GameTime gt, SpriteBatch sb)
		{
			if (visible)
			{
				sb.Draw(sprite, position + origin, spritebox, Color.White, rotation, origin, Constants.scale, SpriteEffects.None, 0f);
			}
		}
	}
}
