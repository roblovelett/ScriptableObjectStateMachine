using System.Collections.Generic;
using Project.Scripts.StateMachine;
using UnityEngine;

namespace Project.Scripts.Player.StateMachine
{
    [CreateAssetMenu(menuName = "StateMachine/Player/State")]
    public class PlayerState : State<PlayerStateData>
    {
        public PlayerAction[] actions;
        public PlayerTransition[] transitions;

        protected override IEnumerable<Action<PlayerStateData>> GetActions()
        {
            return actions;
        }

        protected override IEnumerable<Transition<PlayerStateData>> GetTransitions()
        {
            return transitions;
        }
    }
}