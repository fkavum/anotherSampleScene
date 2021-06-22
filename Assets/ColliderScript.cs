using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    int i = 3;
    private void OnCollisionEnter(Collision collision)
    {
        i = 5;
    }
}
