using Player;
using UnityEngine;

namespace Commands
{
    public class MovementCommand : ICommand
    {
        private Rigidbody _rb;
        private float _speed;
        private Vector3 _direction;
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
            _speed = controller.currentSpeed;
            var velocity =  controller.direction * _speed * Time.fixedDeltaTime ;
            velocity.y = _rb.velocity.y;
        
            _rb.velocity = velocity ;
        }
    }
}
