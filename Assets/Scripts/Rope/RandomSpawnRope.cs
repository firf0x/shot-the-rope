using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnRope : MonoBehaviour
{
    [SerializeField]
    private int count;
    [SerializeField]
    private float rotate;
    [SerializeField]
    private GameObject objects;
    [SerializeField]
    private GameObject ropeObject;
    private Rope rope;
    public GameObject GeneralPlane;

    private void randomRotate()
    {
        rotate = Random.Range(0, 361);
        objects.transform.rotation = Quaternion.AngleAxis(rotate, Vector3.right);
    }

    private void spawnPosition()
    {
        for(int index = 0; index <= count; index++)
        {
            Instantiate(objects, transform);
            randomRotate();
            int x = Random.Range(0, 6);
            int y = Random.Range(0, 14);
            int z = Random.Range(-1, -3);
            objects.transform.position = new Vector3(x,y,z);
        }
    }
}
