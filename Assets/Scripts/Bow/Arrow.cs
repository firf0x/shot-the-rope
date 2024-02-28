using UnityEngine;
public class Arrow : MonoBehaviour
{
    [SerializeField] private GameObject Arr;
    public Transform targetPoint;
    [SerializeField]
    private float speed = 2.0f;
    [SerializeField]
    private RunPlane Script;
    [SerializeField]
    private GameObject SpawnArrow;
    public CheckHitRope checkHit;
    void Update()
    {
        if (targetPoint != null)
        {
            Vector3 direction = (targetPoint.position - gameObject.transform.position).normalized;
            gameObject.transform.position += direction * speed * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

        }
    }
    private void OnTriggerEnter(Collider other) {
        Destroy(checkHit.colorRope);
        checkPlane();
        gameObject.transform.position = SpawnArrow.transform.position;
        gameObject.transform.rotation = SpawnArrow.transform.rotation;
        targetPoint = null;
        Debug.Log("удалён");
    }
    private void checkPlane()
    {
        if(checkHit.colorRope == null)
        {
            Script.max = 60;
            Script.enabled = true;
        }
    }
}