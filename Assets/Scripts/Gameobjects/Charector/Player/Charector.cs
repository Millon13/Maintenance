using Game.Scripts.GameObjects.Components.Ground;
using UnityEngine;

namespace DefaultNamespace
{
    public class Charector : MonoBehaviour, JumpComponent.IAction,
        JumpComponent.ICondition
    {

        [SerializeField] private JumpComponent _jumpComponent;
        [SerializeField] private GroundedComponent _groundedComponent;

        private void Awake()
        {   if (_jumpComponent == null) _jumpComponent = GetComponent<JumpComponent>();
            _jumpComponent = GetComponent<JumpComponent>();
            _groundedComponent = GetComponent<GroundedComponent>();
            _jumpComponent.SetCondition(this);
            _jumpComponent.SetAction(this);
        }



        void JumpComponent.IAction.Invoke()
        {
            _jumpComponent.TryJump();
        }



        bool JumpComponent.ICondition.Evaluate() =>  _groundedComponent.IsGrounded;
    }

}