using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceRTS
{
    class Unit : GameObject
    {
        protected Vector2 curSpeed, destination;
        protected float maxSpeed, attackRange, collisionRange, acceleration = 0.1f;
        protected Unit target;

        public Vector2 CurSpeed { get => curSpeed; set => curSpeed = value; }
        public Vector2 Destination { get => destination; set => destination = value; }
        public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public float AttackRange { get => attackRange; set => attackRange = value; }
        public float CollisionRange { get => collisionRange; set => collisionRange = value; }
        public Unit Target { get => target; set => target = value; }
        public float Acceleration { get => acceleration; set => acceleration = value; }

        public Unit() : base()
        {

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

        public void Move(float gtfrac)
        {
            if (curSpeed.Length() > maxSpeed)
            {
                curSpeed.Normalize();
                curSpeed *= maxSpeed;
            }
            else if (curSpeed.Length() < 0.98f * maxSpeed) // 98% of maxSpeed is also ok
            {
                Vector2 dir = destination - position;
                dir.Normalize();
                curSpeed += dir * acceleration;
            }

            position += curSpeed * gtfrac;
        }

    }
}
