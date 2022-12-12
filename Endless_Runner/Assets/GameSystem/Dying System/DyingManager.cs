using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSystem.ReloadSystem;
using GameSystem.PlayerSystem;


namespace GameSystem
{
    namespace DyingSystem
    {
        public class DyingManager : MonoBehaviour
        {
            // Start is called before the first frame update
            public Animator Player;
            public ReloadManager ReloadScene;
            public PlayerMovements move;
            public Rigidbody rb;
            public AudioSource dyingAudio;
            public Vector3 dieval; //z = 2
            void Start()
            {
                
            }

            // Update is called once per frame
            void Update()
            {

            }
            private void OnTriggerEnter(Collider collision)
            {
                if (collision.tag == "obstacles")
                {
                    Debug.Log(collision.name);
                    Player.SetBool("dying", true);
                    Player.SetBool("run", false);
                    ReloadScene.ReLoad();


                    move.horMultilpier = 0;
                    move.speed = 0;

                    rb.MovePosition(rb.position - dieval);

                    dyingAudio.Play();

                }

            }
        }
    }
}
