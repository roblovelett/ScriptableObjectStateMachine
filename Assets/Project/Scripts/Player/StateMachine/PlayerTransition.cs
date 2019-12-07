using System;
using Project.Scripts.StateMachine;

namespace Project.Scripts.Player.StateMachine
{
    [Serializable]
    public class PlayerTransition : Transition<PlayerStateData>
    {
        public PlayerDecision decision;
        public PlayerState falseState;
        public PlayerState trueState;

        public override Decision<PlayerStateData> GetDecision()
        {
            return decision;
        }

        public override State<PlayerStateData> GetTrueState()
        {
            return trueState;
        }

        public override State<PlayerStateData> GetFalseState()
        {
            return falseState;
        }
    }
}