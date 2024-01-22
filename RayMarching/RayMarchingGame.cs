using MyEngine;
namespace RayMarching
{
    class RayMarchingGame : Game
    {
        protected override void SetStartingState()
        {
            state = new RayMarchingState(); 
        }
    }
}
