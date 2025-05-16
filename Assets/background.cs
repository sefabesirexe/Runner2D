using UnityEngine;

public class background : MonoBehaviour
{
    public float speed;
    public Renderer bgRenderer;
    void Start()
    {
        //mapdegis.I.UpdateQuadMaterial(1);
    }

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
