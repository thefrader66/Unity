using UnityEngine;

public class LifeWastedTracker : MonoBehaviour
{
    private float acceleratorTime = 0f;
    public bool acceleratorRunning = true;

    void Update()
    {
        if (acceleratorRunning)
        {
            acceleratorTime += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            ShowLifeWasted();
        }
    }

    void ShowLifeWasted()
    {
        int hours = Mathf.FloorToInt(acceleratorTime / 3600);
        int minutes = Mathf.FloorToInt((acceleratorTime % 3600) / 60);
        int seconds = Mathf.FloorToInt(acceleratorTime % 60);

        Debug.Log("You have wasted " + hours + "h " + minutes + "m " + seconds + "s of your life using the particle accelerator!");
    }
}