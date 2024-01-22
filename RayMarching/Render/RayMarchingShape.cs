using SFML.System;

namespace RayMarching.Render
{
    abstract class RayMarchingShape
    {
        public Vector3f position;

        public abstract float calculateDistanceTo(Vector3f otherPosition);
    }
}
