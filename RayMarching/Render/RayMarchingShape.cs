using SFML.Graphics;
using SFML.System;

namespace RayMarching.Render
{
    abstract class RayMarchingShape
    {
        public Vector3f position;
        public Color color;

        protected RayMarchingShape(Vector3f position, Color color)
        {
            this.position = position;
            this.color = color;
        }

        public abstract float calculateDistanceTo(Vector3f otherPosition);
    }
}
