using Commands;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        // Start is called before the first frame update

        [Range(0,500)] public float currentSpeed;
        [Range(0, 1000)] public float jumpForce;

        public Vector3 direction; 

        private MovementCommand _movementCommand = new MovementCommand();
        private JumpCommand _jumpCommand = new JumpCommand();
    
        void Start()
        {
            _movementCommand.Init(this);
            _jumpCommand.Init(this);
        }

        // Update is called once per frame
        void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
        
            direction = new Vector3(horizontal,0,vertical);
            _movementCommand.Execute(this);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _jumpCommand.Execute(this);
            }
        }
    }
}
