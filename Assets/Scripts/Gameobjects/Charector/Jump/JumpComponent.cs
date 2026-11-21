using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class JumpComponent : MonoBehaviour
    {
        
        public interface IAction
        {
            void Invoke();
        }

        public interface ICondition
        {
            bool Evaluate();
        }

        private IAction _jumpAction;
        private ICondition _condition;

        public void SetAction(IAction action) => _jumpAction = action;

        public void SetCondition(ICondition condition) => _condition = condition;

        [SerializeField] private bool _jumpRequired;

        [SerializeField] private float _jumpDuration = 0.1f;

        [SerializeField] private float _jumpTime;

        public Action<bool> OnJump;

        [SerializeField] private Vector3 force;

        [SerializeField] Rigidbody _rigidbody;

        public void Jump()
        {
            _jumpRequired = true;
        }

        public void FixedUpdate()
        {
            if (_jumpRequired && (_condition == null || _condition.Evaluate()))
            {
                _jumpAction?.Invoke();
                _jumpTime = Time.time + _jumpDuration;
                this.OnJump?.Invoke(true);
            }

            _jumpRequired = false;
        }


        public void TryJump()
        {
            if (force == null || _rigidbody == null) return;
            _rigidbody.AddForce(force, ForceMode.Impulse);
        }
    }
    
}