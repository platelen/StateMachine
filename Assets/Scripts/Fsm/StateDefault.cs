using UnityEngine;

namespace Fsm
{
    public abstract class StateDefault
    {
        protected StateMachine _stateMachine;
        public Color StateColor;

        protected StateDefault(Color stateColor, StateMachine stateMachine)
        {
            StateColor = stateColor;
            _stateMachine = stateMachine;
        }

        public virtual void Execute()
        {
            _stateMachine.ChangeColor(StateColor);
        }

        public virtual void ChangeState()
        {
        }
    }
}