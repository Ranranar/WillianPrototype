using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumbsThrowed : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        MoonNumber.crumbsRemained -= 1;
        Destroy(gameObject);
    }
}