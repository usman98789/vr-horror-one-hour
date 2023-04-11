using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public int count = 0;

    private void Update() {
        if (count == 1) {
            SceneManager.LoadScene("win");
        }
    }
}
