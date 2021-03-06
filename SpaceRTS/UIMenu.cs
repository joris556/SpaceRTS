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
	class UIMenu
	{
		protected List<UIObject> UIObjects;
		protected Vector2 offset;
		protected Vector2 cameraOffset;
		protected float scale;
		protected bool mainScreen;

		public Vector2 Offset { get => offset; set => offset = value; }
		public float Scale { get => scale; set => scale = value; }
		public Vector2 CameraOffset { get => cameraOffset; set => cameraOffset = value; }
		public bool MainScreen { get => mainScreen; set => mainScreen = value; }
		public List<UIObject> UIOBJECTS{ get => UIObjects; set => UIObjects = value; }

		public UIMenu()
		{
			UIObjects = new List<UIObject>();
			offset = Vector2.Zero;
			cameraOffset = Vector2.Zero;
			scale = 0f;
			mainScreen = true;

			AddUIObjects();

		}


		public void Update(GameTime gt)
		{
			foreach (UIObject g in UIObjects)
				g.Update(gt);
		}

		public void HandleInput(InputHelper ih)
		{
			foreach (UIObject g in UIObjects)
				g.HandleInput(ih);
		}

		public void Draw(GameTime gt, SpriteBatch sb)
		{

			foreach (UIObject g in UIObjects)
				g.Draw(gt, sb);

		}

		private void AddUIObjects()
		{
			UIObjects.Add(new DNDObject() { Position = new Vector2(2, 2), Sprite = Game1.AssetHelper.GetSprite("factory"), Clickbox = new Rectangle(2, 2, 100, 100), Spritebox = new Rectangle(0 , 0, 100, 100)  });
		}
	}
}
