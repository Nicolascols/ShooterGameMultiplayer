using Player;
using UnityEngine;

namespace Commands
{
    public class JumpCommand : ICommand
    {
        private Rigidbody _rb;

        public void Init(PlayerController actor)
        {
            if (actor == null)
            {
                Debug.LogError("MoveCommand with null actor");
                return;
            }

            if (!actor.TryGetComponent(out _rb))
            {
                Debug.LogError($"{actor.name} with null Rigidbody");

            }
        }
    

        public void Load()
        {
        }

        public void Execute(PlayerController controller)
        {
            _rb.AddForce(Vector3.up * controller.jumpForce); 
        }

    }
}
