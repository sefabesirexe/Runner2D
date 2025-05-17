using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;
    public int score2 = 1;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        ScoreManager.Instance.AddScore(0);
        score2 = 0;
    }


    public void AddScore(int amount)
    {
        score2 += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        score2 += 2000;      
        scoreText.text = "Score: " + score.ToString();
       
    }

    void Update()
    {
        scoreText.text = "Score: " + score2.ToString();
        score2++;
    }
}
