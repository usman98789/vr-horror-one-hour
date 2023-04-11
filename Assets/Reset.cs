using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ResetScene", 2f);
    }

    // Update is called once per frame
    private void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
