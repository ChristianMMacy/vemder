using UnityEditor.UIElements;
using UnityEngine;

namespace Object
{
    public class Movement : MonoBehaviour
    {
        public Rigidbody2D rb;
        public int speed = 100;

        // Start is called before the first frame update
        void Start()
        {
            rb.AddForce(new Vector2(speed, 0));
        }

        // Update is called once per frame
        void FixedUpdate()
        {
        }
    }
}
