using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
public class run : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D coll;
    public bool yeredegiyormu;

    public LayerMask groundLayer;

    void Update()
    {
        if (Input.GetKeyDown("space") && yeredegiyormu)
        {
            rb.linearVelocity = new Vector2(0, 5);
            yeredegiyormu = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ground"))
        yeredegiyormu = true;
    }
}
