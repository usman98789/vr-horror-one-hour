using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateOnHandInput : MonoBehaviour
{
    [SerializeField] InputActionProperty pinchAnimation;
    [SerializeField] InputActionProperty gripAnimation;

    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float triggerValue = pinchAnimation.action.ReadValue<float>();
        anim.SetFloat("Trigger", triggerValue);
        
        float gripValue = gripAnimation.action.ReadValue<float>();
        anim.SetFloat("Grip", gripValue);
    }
}
