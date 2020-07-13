using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace SpaceRTS
{
    class Constants
    {
        public static Point screenSize = new Point(1920, 1080);
        public static float scale = 1f;
		public static float sScale = 0.2f;

		public static Vector2 SOffset()
		{
			return screenSize.ToVector2() - sScale * screenSize.ToVector2();
		}

    }
}
