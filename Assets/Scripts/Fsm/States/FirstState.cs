using UnityEngine;

namespace Fsm.States
{
    public class FirstState : StateDefault
    {
        public FirstState(Color stateColor, StateMachine stateMachine) : base(stateColor, stateMachine)
        {
        }

        public override void Execute()
        {
            Debug.Log("First State");
            base.Execute();
        }

        public override void ChangeState()
        {
            _stateMachine.SetState(_stateMachine.SecondState);
        }
    }
}