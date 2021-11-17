using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void onTriggerEnter(Collider other)
    {


        Destroy(gameObject);
    }
}
