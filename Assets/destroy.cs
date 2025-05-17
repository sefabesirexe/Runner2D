using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("enemy"))
        Destroy(gameObject);

        if (col.CompareTag("coin"))
        {
            ScoreManager.Instance.AddScore(1); 
            Destroy(col.gameObject); 
        }
    }
}
