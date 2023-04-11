using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{


    public void DestroyObject() {
        Invoke("Destroyed", 2f);
    }

    public void Destroyed() {
        Destroy(gameObject);
    }
}
