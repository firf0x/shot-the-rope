using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStartGame : MonoBehaviour
{
    [SerializeField] private RunPlane plane;
    private UIStartGame uIStart;
    private GameObject _object;

    public void StartGame()
    {
        uIStart = GetComponent<UIStartGame>();
        _object = GameObject.FindWithTag("LVL");
        plane = _object.GetComponent<RunPlane>();
        plane.enabled = true;
        uIStart.enabled = false;
    }

}
