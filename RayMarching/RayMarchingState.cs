using MyEngine;
using MyEngine.States;
using SFML.Window;

namespace RayMarching
{
    class RayMarchingState : State
    {
        public override void Input()
        {
            Game.window.DispatchEvents();
        }

        public override void Render()
        {
            Game.window.Clear();
        }

        public override void Update()
        {
            
        }
    }
}
