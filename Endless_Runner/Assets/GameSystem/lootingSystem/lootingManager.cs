using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSystem.ScoringSystem;

namespace GameSystem
{
    namespace LootingSystem
    {
        public class lootingManager : MonoBehaviour
        {
            // Start is called before the first frame update
            public ScoreManager manageScore;
            public AudioSource CoinSound;


            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
            private void OnTriggerEnter(Collider other)
            {
                if (other.tag == "coin")
                {
                    CoinSound.Play();
                    manageScore.score++;
                    Destroy(other.gameObject);
                }
            }
        }
    }
}