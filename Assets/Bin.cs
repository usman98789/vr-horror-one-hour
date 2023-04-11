using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 7) {
            GameObject.Find("Counter").GetComponent<Counter>().count += 1;
            other.gameObject.GetComponent<Trash>().DestroyObject();
        }
    }
}
