using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem
{
    namespace CoinSystem
    {
        public class CoinRotation : MonoBehaviour
        {
            // Start is called before the first frame update
            public float turnSpeed = 90f;
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                Rotate();
            }
            void Rotate()
            {
                transform.Rotate(turnSpeed * Time.deltaTime, 0, 0);
            }
        }
    }
}
        