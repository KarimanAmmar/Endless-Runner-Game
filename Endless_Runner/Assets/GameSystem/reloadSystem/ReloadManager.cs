using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    namespace ReloadSystem
    {
        public class ReloadManager : MonoBehaviour
        {
            // Start is called before the first frame update
           
            public void ReLoad()
            {
                StartCoroutine(IsWaiting());
            }
           

            IEnumerator IsWaiting()
            {
                yield return new WaitForSeconds(5);

                SceneManager.LoadScene("UI");


            }


        }

    }
}
