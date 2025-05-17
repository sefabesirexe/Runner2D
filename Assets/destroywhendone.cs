using UnityEngine;

public class destroywhendone : MonoBehaviour
{
    void Update()
    {
         if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
