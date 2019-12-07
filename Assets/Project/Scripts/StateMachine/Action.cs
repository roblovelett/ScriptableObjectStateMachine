using UnityEngine;

namespace Project.Scripts.StateMachine
{
    public abstract class Action<T> : ScriptableObject where T : ObjectStateData
    {
        public abstract void Act(T data);
    }
}