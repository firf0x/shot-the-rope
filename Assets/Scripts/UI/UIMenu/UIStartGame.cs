using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStartGame : MonoBehaviour
{
    [SerializeField] private RunPlane plane;

    private void Start() {
        plane.enabled = false;
    }

}
