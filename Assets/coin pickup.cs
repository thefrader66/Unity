using UnityEngine;
using UnityEngine.Rendering;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int score = 1;
    private ScoreMangemt scoreMangemt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreMangemt = FindAnyObjectByType<ScoreMangemt>();
    }
    private void OnTriggerEnter(Collider other)
    {
       scoreMangemt.Addscore(score);
        Destroy(gameObject);
    }
}
