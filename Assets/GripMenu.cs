using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GripMenu : MonoBehaviour
{
    [SerializeField] InputActionProperty gripProperty;

    private void Update() {
        float gripValue = gripProperty.action.ReadValue<float>();
        if (gripValue > 0.5f) {
            SceneManager.LoadScene(0);
        }
    }
}
