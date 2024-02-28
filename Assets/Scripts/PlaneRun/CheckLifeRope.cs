using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLifeRope : MonoBehaviour
{
    private GameObject[] _object;
    [SerializeField]
    private string Tags;
    private GameObject[] ScriptRunPlane;
    private RunPlane runPlane;


    public void checkLife()
    {
        ScriptRunPlane = GameObject.FindGameObjectsWithTag("LVL");
        runPlane = ScriptRunPlane[0].GetComponent<RunPlane>();
        _object = GameObject.FindGameObjectsWithTag(Tags);

        if(_object.Length == 0)
        {
            Debug.LogWarning($"Нету объекта с тегом {Tags}");
            runPlane.max = 60;
            runPlane.enabled = true;
        }

    }

}
