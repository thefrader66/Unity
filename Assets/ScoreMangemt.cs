using TMPro;
using UnityEngine;

public class ScoreMangemt : MonoBehaviour
{   
    public int Score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Addscore(int amount)
    {
        Score += amount;
        updatetext();
    }

    void updatetext()
    {
        scoreText.text = "score: " + Score;
    }
}
