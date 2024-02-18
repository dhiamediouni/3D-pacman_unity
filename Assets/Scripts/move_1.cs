using UnityEngine;

public class move_1 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horz = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");

        Vector3 mvt = new Vector3(Horz, 0f, Vert);
        rb.velocity = new Vector3(mvt.x * speed * Time.deltaTime, rb.velocity.y, mvt.z * speed * Time.deltaTime);

        if (Input.GetMouseButtonUp(0))
        {
            UnityEngine.Debug.Log("Left button Clicked");
        }
        if (Input.GetMouseButtonUp(1))
        {
            UnityEngine.Debug.Log("Right button Clicked");
        }
    }
}
