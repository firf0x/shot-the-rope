using UnityEngine;
public class Arrow : MonoBehaviour
{
    [SerializeField] Transform[] targetpos;
    [SerializeField] float speed = 2f;
    [SerializeField] float speed1 = 2f;
    [SerializeField] float speedrotate = 5f;
    [SerializeField] float speedrotate1 = 4f;
    [SerializeField] Transform balpos;
    [SerializeField] GameObject cam;
    private int index;
    public bool trigg = false;
    public void Start()
    {
        int random = Random.Range(0, targetpos.Length);
        index = random;
    }
    public void Update()
    {
        if (trigg == false)
        {
            cam.SetActive(false);
            transform.position = Vector3.MoveTowards(transform.position, balpos.position, speed1 * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, balpos.rotation, speedrotate1 * Time.deltaTime);
        }
        if (trigg == true)
        {
            cam.SetActive(true);
            transform.position = Vector3.MoveTowards(transform.position, targetpos[index].position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetpos[index].rotation, speedrotate * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        trigg = true;
    }
}