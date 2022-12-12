using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem
{
    namespace GroundSystem
    {
        public class GroundManager : MonoBehaviour
        {
          

         

        }
    }
}


//public GameObject[] grounds;
//private Transform player;
//float spawnZ = 0.0f;
//float GroundLength = 140.5f;
//int amountofgrounds = 3;
//void Start()
//{
//    player = GameObject.FindGameObjectWithTag("Player").transform;
//    for (int i = 0; i < amountofgrounds; i++)
//    {
//        SpawnGround();
//    }
//}
//private void Update()
//{
//    if (player.position.z > (spawnZ - amountofgrounds * GroundLength)) ;
//}
//void SpawnGround(int prefabIndex = -1)
//{
//    GameObject go;
//    go = Instantiate(grounds[0]) as GameObject;
//    go.transform.SetParent(transform);
//    go.transform.position = Vector3.forward * spawnZ;
//    spawnZ += GroundLength;
//}
//public GameObject ground;
//public int GroundAmount;

//List<GameObject> grounds;

//void Start()
//{
//    grounds = new List<GameObject>();

//    for (int i = 0; i < GroundAmount; i++)
//    {
//        GameObject obj = Instantiate(ground);
//        obj.SetActive(false);
//        grounds.Add(obj);
//    }
//}

//// Update is called once per frame
//void Update()
//{

//}
//public GameObject GetPooled()
//{
//    for (int i = 0; i < grounds.Count; i++)
//    {
//        if (!grounds[i].activeInHierarchy)
//        {
//            return grounds[i];
//        }
//    }
//    GameObject obj = Instantiate(ground);
//    obj.SetActive(false);
//    grounds.Add(obj);

//}