using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("enemy"))
        Destroy(gameObject);

        SceneManager.LoadScene("DeathScene");
        

        if (col.CompareTag("coin"))
        {
            ScoreManager.Instance.AddScore(1);
            Destroy(col.gameObject);
        }
    }
}
