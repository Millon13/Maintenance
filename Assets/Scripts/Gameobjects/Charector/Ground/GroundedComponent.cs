using System;

using UnityEngine;

namespace Game.Scripts.GameObjects.Components.Ground
{
    [Serializable]
    public sealed class GroundedComponent : MonoBehaviour
    {
        public event Action<bool> OnGrounded;

        [SerializeField] private Transform _feet;

        [SerializeField] private LayerMask _layerMask;

        [SerializeField] private float _groundDistance = 0.15f;
        

        [SerializeField]
        private bool _isGrounded;
        

        public bool IsGrounded => _isGrounded;

        private void FixedUpdate()
        {
            bool grounded = false;
            RaycastHit hit;

            if (Physics.Raycast(_feet.position, Vector3.down, out hit, _groundDistance, _layerMask, QueryTriggerInteraction.Ignore))
            {
                grounded = hit.collider != null;
            }

            if (grounded != _isGrounded)
            {
                _isGrounded = grounded;
                OnGrounded?.Invoke(_isGrounded);
            }
        }

        private void OnDrawGizmos()
        {
            if (_feet == null) return;

            Gizmos.color = _isGrounded ? Color.green : Color.yellow;
            Gizmos.DrawLine(_feet.position, _feet.position + Vector3.down * _groundDistance);
            Gizmos.DrawWireSphere(_feet.position + Vector3.down * _groundDistance, 0.02f);
        
        }
    }
}