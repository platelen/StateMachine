using UnityEngine;

namespace Fsm.States
{
    public class FourthState : StateDefault
    {
        public FourthState(Color stateColor, StateMachine stateMachine) : base(stateColor, stateMachine)
        {
        }

        public override void Execute()
        {
            Debug.Log("Fourth State");
            base.Execute();
        }

        public override void ChangeState()
        {
            _stateMachine.DestroyThis();
            Debug.Log("Destroy this shit");
        }
    }
}