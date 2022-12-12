using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameSystem
{
    namespace ScoringSystem
    {
        public class ScoreManager : MonoBehaviour
        {
            public int score;
            public TextMeshProUGUI scoreText;

            void Update()
            {
                SetScore();
            }

            void SetScore()
            {
                scoreText.text = "Score :" + score;
            }
        }
    }
}
