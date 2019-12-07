using UnityEngine;

namespace Project.Scripts.StateMachine
{
    public abstract class StateController<T> : MonoBehaviour where T : ObjectStateData
    {
        public T stateData;
        protected abstract State<T> GetCurrentState();
        protected abstract State<T> GetRemainState();
        protected abstract void SetCurrentState(State<T> state);

        private void Update()
        {
            GetCurrentState().UpdateState(this);
        }

        public void TransitionToState(State<T> nextState)
        {
            if (nextState != GetRemainState()) SetCurrentState(nextState);
        }
    }
}