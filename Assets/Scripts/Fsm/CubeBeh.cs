using System;
using UnityEngine;

namespace Fsm
{
    public class CubeBeh : MonoBehaviour
    {
        [SerializeField] private GameObject _cube;
        [Header("Colors")] [SerializeField] private Color _firstColor;
        [SerializeField] private Color _secondColor;
        [SerializeField] private Color _thirdColor;

        public enum States
        {
            First,
            Second,
            Third
        }

        private States _currentState;
        private Renderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
            _currentState = States.First;
            AssignColorFromState();
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                print("NextState");
                _currentState++;
                States[] allStates = (States[]) Enum.GetValues(typeof(States));

                if ((int) _currentState >= allStates.Length)
                {
                    _currentState = allStates[0];
                }

                AssignColorFromState();
            }
        }

        private void AssignColorFromState()
        {
            switch (_currentState)
            {
                case States.First:
                    _renderer.material.color = _firstColor;
                    break;
                case States.Second:
                    _renderer.material.color = _secondColor;
                    break;
                case States.Third:
                    _renderer.material.color = _thirdColor;
                    break;
            }
        }
    }
}