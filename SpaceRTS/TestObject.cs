using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceRTS
{
    class TestObject : GameObject
    {

        public TestObject ()
        {
            sprite = Game1.AssetHelper.GetSprite("ls2");
            spritebox = new Rectangle(0, 0, 800, 800);
        }

        public override void Draw(GameTime gt, SpriteBatch sb)
        {
            base.Draw(gt, sb);
        }

        public override void HandleInput(InputHelper ih)
        {
            base.HandleInput(ih);
        }

        public override void Update(GameTime gt)
        {
            base.Update(gt);
        }
    }
}
