using Project.Scripts.StateMachine;

namespace Project.Scripts.Player.StateMachine
{
    public class PlayerStateController : StateController<PlayerStateData>
    {
        public PlayerState currentState;
        public PlayerState remainInState;
        protected override State<PlayerStateData> GetCurrentState()
        {
            return currentState;
        }
        protected override State<PlayerStateData> GetRemainState()
        {
            return remainInState;
        }
        protected override void SetCurrentState(State<PlayerStateData> state)
        {
            currentState = state as PlayerState;
        }
    }
}