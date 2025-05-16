using System.Collections;
using UnityEngine;

public class mapdegis : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static mapdegis I;

    public GameObject quadObject;

    public Material[] materials;

    private Material currentMaterial;

    public Renderer renderer;

    private int currentIndex;

    public SpriteRenderer fadeSprite;

    void Awake()
    {
        I = this;
        currentIndex = 1;
        UpdateQuadMaterial(currentIndex);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            IncrementAge();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DecAge();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(RandomAge());
        }

    }

    IEnumerator FadeIn()
    {
        float i = 0;
        Color fadecolor = new Color(0, 0, 0, 0);
        Color blackColor = Color.black;
        while (i < 1)
        {
            i = i + Time.deltaTime/2f;
            fadeSprite.color = Color.Lerp(fadecolor, blackColor, i);
            yield return new WaitForEndOfFrame();
        }

    }

    IEnumerator FadeOut()
    {
        float i = 1;
        Color fadecolor = new Color(0, 0, 0, 0);
        Color blackColor = Color.black;

        while (i > 0)
        {
            i = i - Time.deltaTime / 2f;
            fadeSprite.color = Color.Lerp(fadecolor, blackColor, i);
            yield return new WaitForEndOfFrame();
        }
    }

    public IEnumerator IncrementAge()
    {
        StartCoroutine(FadeIn());
        yield return new WaitForSeconds(1);

        currentIndex = currentIndex + 1;
        currentIndex = currentIndex % materials.Length;
        UpdateQuadMaterial(currentIndex);

        StartCoroutine(FadeOut());
    }

    public void DecAge()
    {
            currentIndex = currentIndex - 1;
            if (currentIndex < 0)
            {
                currentIndex = 2;
            }
            UpdateQuadMaterial(currentIndex);
    }

    public IEnumerator RandomAge()
    {
        StartCoroutine(FadeIn());
        yield return new WaitForSeconds(2);


        int enterIndex = currentIndex;
        while (currentIndex == enterIndex)
        {
            currentIndex = Random.Range(0, materials.Length);
        }
        UpdateQuadMaterial(currentIndex);
        StartCoroutine(FadeOut());
    }


    public void UpdateQuadMaterial(int index)
    {
        renderer.material = materials[index];
    }


}
