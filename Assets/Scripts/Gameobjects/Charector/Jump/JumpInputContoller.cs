using UnityEngine;

namespace DefaultNamespace
{
    public class JumpInputContoller:MonoBehaviour

    {
        [SerializeField] private GameObject _character;

        private void Update()
        {
            HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _character.GetComponent<JumpComponent>().Jump();
        }
    }
}