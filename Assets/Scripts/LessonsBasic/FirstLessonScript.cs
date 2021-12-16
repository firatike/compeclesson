using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LessonsBasic
{
    public class FirstLessonScript : MonoBehaviour
    {

        public float FloatProperty { get; private set; }
        void Start()
        {
            FloatProperty = 100000f;
        }


        void Update()
        {

        }
    }
}
