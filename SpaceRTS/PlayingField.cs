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
	class PlayingField
	{
		protected List<GameObject> gameObjects;
		protected Vector2 offset;
		protected Vector2 cameraOffset;
		protected float scale;
		protected bool mainScreen;

		public Vector2 Offset { get => offset; set => offset = value; }
		public float Scale { get => scale; set => scale = value; }
		public Vector2 CameraOffset { get => cameraOffset; set => cameraOffset = value; }
		public bool MainScreen { get => mainScreen; set => mainScreen = value; }
		public List<GameObject> GameObjects { get => gameObjects; set => gameObjects = value; }

		public PlayingField()
		{
			GameObjects = new List<GameObject>();
			offset = Vector2.Zero;
			cameraOffset = Vector2.Zero;
			scale = 0f;
			mainScreen = true;
            gameObjects.Add(new TestObject());
        }

		public virtual void Update(GameTime gt)
		{
			foreach (GameObject g in GameObjects)
				g.Update(gt);
		}

		public virtual void HandleInput(InputHelper ih)
		{
			foreach (GameObject g in GameObjects)
				g.HandleInput(ih);
		}

		public virtual void Draw(GameTime gt, SpriteBatch sb)
		{

			foreach (GameObject g in GameObjects)
				g.Draw(gt, sb);

		}

		public virtual void Switch()
		{
			foreach (GameObject g in GameObjects)
				g.MainScreen = mainScreen;
		}
	}
}
