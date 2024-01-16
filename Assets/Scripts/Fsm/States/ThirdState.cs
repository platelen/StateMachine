using UnityEngine;

namespace Fsm.States
{
    public class ThirdState : StateDefault
    {
        public ThirdState(Color stateColor, StateMachine stateMachine) : base(stateColor, stateMachine)
        {
        }

        public override void Execute()
        {
            Debug.Log("Third State");
            base.Execute();
        }

        public override void ChangeState()
        {
            _stateMachine.SetState(_stateMachine.FourthState);
        }
    }
}