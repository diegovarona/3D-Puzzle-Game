using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestory : MonoBehaviour
{
    void OnCollisionEnter(Collision Other)
    {
        Destroy(gameObject);
    }
}
