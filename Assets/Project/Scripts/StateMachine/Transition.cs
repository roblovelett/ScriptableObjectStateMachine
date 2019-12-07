using System;

namespace Project.Scripts.StateMachine
{
    [Serializable]
    public abstract class Transition<T> where T : ObjectStateData
    {
        public abstract Decision<T> GetDecision();
        public abstract State<T> GetTrueState();
        public abstract State<T> GetFalseState();
    }
}