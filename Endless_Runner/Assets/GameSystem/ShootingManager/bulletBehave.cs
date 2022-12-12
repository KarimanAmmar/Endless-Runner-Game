using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem
{
    namespace ShootingSystem
    {
        public class bulletBehave : MonoBehaviour
        {
            public float speed;
            // Start is called before the first frame update
            void Start()
            {
                Destroy(gameObject, 3);
            }

            // Update is called once per frame
            void Update()
            {
                move();
            }
            public void move()
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
