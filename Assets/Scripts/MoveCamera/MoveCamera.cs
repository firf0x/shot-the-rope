using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private MoveCamera cam;
    private Animator animator;
    private void Start() {
        cam = GetComponent<MoveCamera>();
        animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        animator.enabled = true;
    }
}
