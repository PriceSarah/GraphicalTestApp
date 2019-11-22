using System;

namespace GraphicalTestApp
{
    class Entity : Actor
    {
        private Vector3 _velocity = new Vector3();
        private Vector3 _acceleration = new Vector3();

        public float XVelocity
        {
            //## Implement velocity on the X axis ##//
            get
            {
                return _velocity.x;

            }
            set
            {
                _velocity.x = value;
            }
        }
        public float XAcceleration
        {
            //## Implement acceleration on the X axis ##//
            get { return 0; }
            set { }
        }
        public float YVelocity
        {
            //## Implement velocity on the Y axis ##//
            get { return 0; }
            set { }
        }
        public float YAcceleration
        {
            //## Implement acceleration on the Y axis ##//
            get { return 0; }
            set { }
        }

        //Creates an Entity at the specified coordinates
        public Entity(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override void Update(float deltaTime)
        {
            //## Calculate velocity from acceleration ##//
            //## Calculate position from velocity ##//
            base.Update(deltaTime);
        }
    }
}
