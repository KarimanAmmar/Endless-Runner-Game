using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem
{
    namespace MonsterSystem
    {


        public class MonsterMovements : MonoBehaviour
        {


            Transform NextPos;
            [SerializeField] Transform[] Positions;

            [SerializeField] float Speed;
            int posIndex;


            void Start()
            {
                NextPos = Positions[0];
            }
            void Update()
            {
                Move();
            }
            void Move()
            {
                if (transform.position == NextPos.position)
                {
                    posIndex++;
                    if (posIndex >= Positions.Length)
                    {
                        posIndex = 0;
                    }
                    NextPos = Positions[posIndex];
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, NextPos.position, Speed * Time.deltaTime);

                }
                transform.LookAt(NextPos);
            }

        }
    }
    }



//public Transform point1;
//public Transform point2;

//[SerializeField] float speed;

//public bool arrivedPoint2;
//public bool arrivedPoint1;
//void Update()
//{
//    Move();

//}
//private void Move()
//{
//    var step = speed * Time.deltaTime;

//    if (Vector3.Distance(transform.position, point2.position) > 0 && !arrivedPoint2 && arrivedPoint1)
//    {
//        transform.position = Vector3.MoveTowards(transform.position, point2.position, step);
//        transform.LookAt(point2);
//    }
//    else
//    {
//        arrivedPoint2 = true;
//        arrivedPoint1 = false;
//    }

//    if (Vector3.Distance(transform.position, point1.position) > 0 && arrivedPoint2 && !arrivedPoint1)
//    {
//        transform.position = Vector3.MoveTowards(transform.position, point1.position, step);
//        transform.LookAt(point1);

//    }
//    else
//    {
//        arrivedPoint2 = false;
//        arrivedPoint1 = true;
//    }


//}




//Transform NextPos;
//[SerializeField] Transform[] Positions;

//[SerializeField] float Speed;
//int posIndex;


//void Start()
//{
//    NextPos = Positions[0];
//}
//void Update()
//{
//    Move();
//}
//void Move()
//{
//    if (transform.position == NextPos.position)
//    {
//        posIndex++;
//        if (posIndex >= Positions.Length)
//        {
//            posIndex = 0;
//        }
//        NextPos = Positions[posIndex];
//    }
//    else
//    {
//        transform.position = Vector3.MoveTowards(transform.position, NextPos.position, Speed * Time.deltaTime);

//    }
//}

//        }