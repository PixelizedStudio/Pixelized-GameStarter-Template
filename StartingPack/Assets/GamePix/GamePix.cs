using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GamePixLibrary
{
    public static class GamePix
    {
        public static void MoveTo(GameObject obj1, GameObject obj2,float speed)
        {
            //call in update
            obj1.transform.position = Vector3.Lerp(obj1.transform.position, new Vector3(obj2.transform.position.x, obj2.transform.position.y, obj2.transform.position.z), speed);
            obj1.transform.rotation = Quaternion.Lerp(obj1.transform.rotation, obj2.transform.rotation, speed);
        }

        public static void MoveForward(GameObject obj,float speed)
        {
            obj.transform.position += obj.transform.forward * Time.deltaTime * speed;
        }

        public static void MoveBackward(GameObject obj, float speed)
        {
            obj.transform.position -= obj.transform.forward * Time.deltaTime * speed;
        }


    }
}

