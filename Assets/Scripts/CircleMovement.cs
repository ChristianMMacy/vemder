using UnityEngine;

namespace Scripts
{
    public class CircleMovement : MonoBehaviour
    {
        public Rigidbody2D Rb;
        public int Speed = 500;

        // Start is called before the first frame update
        void Start()
        {
            // Start the ball moving horizontally
            Rb.AddForce(new Vector2(Speed, 0));
        }
    }
}
