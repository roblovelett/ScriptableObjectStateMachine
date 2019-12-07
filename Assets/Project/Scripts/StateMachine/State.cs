using System.Collections.Generic;
using UnityEngine;

namespace Project.Scripts.StateMachine
{
    public abstract class State<T> : ScriptableObject where T : ObjectStateData
    {
        protected abstract IEnumerable<Action<T>> GetActions();
        protected abstract IEnumerable<Transition<T>> GetTransitions();

        public void UpdateState(StateController<T> controller)
        {
            DoActions(controller.stateData);
            CheckTransitions(controller);
        }

        private void DoActions(T data)
        {
            var actions = GetActions();
            foreach (var action in actions) action.Act(data);
        }

        private void CheckTransitions(StateController<T> controller)
        {
            var transitions = GetTransitions();
            foreach (var transition in transitions)
                controller.TransitionToState(transition.GetDecision().Decide(controller.stateData)
                    ? transition.GetTrueState()
                    : transition.GetFalseState());
        }
    }
}