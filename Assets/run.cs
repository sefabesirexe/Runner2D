using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
public class run : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D coll;
    public bool yeredegiyormu;
    public bool zipliyormu;

    public float jumpForce;
    public float yeredusur;


    public LayerMask groundLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yeredegiyormu)
        {
            zipliyormu = true;
            rb.linearVelocity = new Vector2(0, jumpForce);
            yeredegiyormu = false;
        }
       
        if (Input.GetKeyUp(KeyCode.Space))
            {
                zipliyormu = false;
            }

        if (!zipliyormu && Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(0f, -jumpForce);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && rb.linearVelocity.y < 0)
        {
            rb.linearVelocity += Vector2.up * Physics2D.gravity.y * (yeredusur - 1) * Time.deltaTime;
        }


    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ground"))
        yeredegiyormu = true;
    }
}
