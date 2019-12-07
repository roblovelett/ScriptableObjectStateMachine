using UnityEngine;

namespace Project.Scripts.StateMachine
{
    public abstract class Decision<T> : ScriptableObject where T : ObjectStateData
    {
        public abstract bool Decide(T data);
    }
}