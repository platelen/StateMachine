using UnityEngine;

namespace Fsm.States
{
    public class SecondState : StateDefault
    {
        public SecondState(Color stateColor, StateMachine stateMachine) : base(stateColor, stateMachine)
        {
        }

        public override void Execute()
        {
            Debug.Log("Second State");
            base.Execute();
        }

        public override void ChangeState()
        {
            _stateMachine.SetState(_stateMachine.ThirdState);
        }
    }
}