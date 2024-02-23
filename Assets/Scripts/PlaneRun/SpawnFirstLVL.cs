using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFirstLVL : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>{};
    public Transform SpawnPosition;

    private void Start() {
        SpawnLVL();
    }

    private void SpawnLVL()
    {
        int index = Random.Range(0, objects.Count);

        Instantiate(objects[index], SpawnPosition);
    }
}
