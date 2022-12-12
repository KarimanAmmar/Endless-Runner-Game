using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSystem.ScoringSystem;

namespace GameSystem
{
    namespace PlayerSystem
    {
        public class PlayerMovements : MonoBehaviour
        {
            public float speed;
            public float horMultilpier;
            float horizontal;
            [SerializeField] int limit;
            ///public bool jumpFlag = false;
           // public int jumpVal;

            public Rigidbody rb;
            public Animator Player;
            public ScoreManager scoreManager;


            private void Start()
            {
                Player.SetBool("run", false);
                
            }
            private void Update()
            {
                horizontal = Input.GetAxis("Horizontal");
                speedup();
                
            }

            private void FixedUpdate()
            {
                StartCoroutine(IsWaiting());
            }

            IEnumerator IsWaiting()
            {
                yield return new WaitForSeconds(2);
                
                //this.GetComponent<Rigidbody>().velocity = (new Vector3(horizontal * 2, 0, 5) * speed);
                Vector3 move = transform.forward * speed * Time.fixedDeltaTime;
                Vector3 horizontalMove = transform.right * horizontal * speed * Time.fixedDeltaTime * horMultilpier;

                rb.MovePosition(rb.position + move + horizontalMove);

                Player.SetBool("run", true);

                
            }

            void speedup()
            {
               
                if (limit < scoreManager.score )
                {
                    limit += limit;
                    speed++;
                }
            }

            //private void OnTriggerEnter(Collider collision)
            //{
            //    if (collision.tag == "Ground")
            //    {
            //        jumpFlag = true;
            //    }

            //}
            //private void Jump()
            //{
            //    if (Input.GetKeyUp(KeyCode.Space) && jumpFlag)
            //    {

            //        Vector3 jump = transform.up * jumpVal * speed * Time.deltaTime;

            //        //this.transform.Translate(Vector3.up * jump);

            //        jumpFlag = false;

            //        Player.SetBool("jump", true);

            //    }
            //    else
            //    {
            //        Player.SetBool("jump", false);
            //    }
            //}

        }
    }
}
