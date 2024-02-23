using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTest : MonoBehaviour
{
    [SerializeField]
    Text TextTest;
    private Data data;

    private void Awake()
    {
        data = Data.Instance;
    }

    private void Start()
    {
        TextTest.text = data.xp.ToString();
    }
}
