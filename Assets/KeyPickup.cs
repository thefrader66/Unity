using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;
    public GameObject pathTodisappear;
    void OnTriggerEnter(Collider other)
    {
        if (pathToAppear) pathToAppear .SetActive(true);
        if (pathTodisappear) pathTodisappear.SetActive(false);
        Destroy(gameObject);
        
    }

}
