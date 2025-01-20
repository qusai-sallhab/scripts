using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        MyTransform trans;
        // Start is called before the first frame update
        void Start()
        {
            trans=new MyTransform(this.transform);
            trans.SetPosition(new Vector3(0, 1, 0))
            .SetRotation(new Vector3(45, 0, 0))
            .SetScale(new Vector3(2, 2, 2));
        }

    }


    public class MyTransform
    {
        private Transform trans;
        public MyTransform(Transform transform)
        {
            trans=transform;
        }
        public MyTransform SetPosition(Vector3 position)
        {
            trans.position=position;
            return this;
        }
        public MyTransform SetRotation(Vector3 rotation)
        {
            trans.rotation=Quaternion.Euler(rotation);
            return this;
        }
        public MyTransform SetScale(Vector3 scale)
        {
            trans.localScale=scale;
            return this;
        }

    }
}