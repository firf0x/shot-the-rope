using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField]
    private Randomint random;
    [SerializeField]
    public List<Material> mat = new List<Material>{};
    private int minValue = 0;

    private void Awake() {
        SetMaterial();
    }  
    public void SetMaterial()
    {
        int index = 0;
        index = Random.Range(minValue, mat.Count);
        while (true)
        {
            index = Random.Range(minValue, mat.Count);
            if (!random.RandomNumbers.Contains(index))
            {
                random.RandomNumbers.Add(index);
                break;
            }
        }
        GetComponent<Renderer>().material = mat[index];
    }
}