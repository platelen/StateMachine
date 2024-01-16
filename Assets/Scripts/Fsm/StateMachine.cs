using Fsm.States;
using UnityEngine;

namespace Fsm
{
    public class StateMachine : MonoBehaviour
    {
        [Header("Colors")] [SerializeField] private Color _firstColor;
        [SerializeField] private Color _secondColor;
        [SerializeField] private Color _thirdColor;
        [SerializeField] private Color _fourthColor;


        public FirstState FirstState;
        public SecondState SecondState;
        public ThirdState ThirdState;
        public FourthState FourthState;

        private StateDefault _currentState;
        private Renderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();

            InitiateStates();

            SetState(FirstState);
        }

        public void SetState(StateDefault newState)
        {
            _currentState = newState;
            _currentState.Execute();
        }

        public void ChangeColor(Color color)
        {
            _renderer.material.color = color;
        }

        public void DestroyThis()
        {
            Destroy(gameObject);
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _currentState.ChangeState();
            }
        }

        private void InitiateStates()
        {
            FirstState = new FirstState(_firstColor, this);
            SecondState = new SecondState(_secondColor, this);
            ThirdState = new ThirdState(_thirdColor, this);
            FourthState = new FourthState(_fourthColor, this);
        }
    }
}