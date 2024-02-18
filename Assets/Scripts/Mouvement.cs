using UnityEngine;
using System.Collections;

public class Mouvment : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 200f;

    private void Start()
    {
        // Check if the Rigidbody component is attached, if not, add it
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
    }

    // Called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "PowerPellet"
        if (collision.gameObject.CompareTag("reward"))
        {
            // Destroy the coin GameObject after a delay
            GameObject coin = collision.gameObject;
            Destroy(coin); // Destroy the coin after 2 seconds
        }
    }

    // Update is called once per frame
    void Update()
    {
        float Horz = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");

        Vector3 mvt = new Vector3(Horz, 0f, Vert);
        rb.velocity = new Vector3(mvt.x * speed * Time.deltaTime, rb.velocity.y, mvt.z * speed * Time.deltaTime);
    }
}
