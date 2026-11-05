using System.Collections;
using TMPro;
using UnityEngine;

public class SnowCounter : MonoBehaviour
{
    public static int SnowCollected;
    public static int MaxSnow;

    public TextMeshProUGUI counter; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SnowCollected = 0;
        MaxSnow = 5;
        counter.text = "Snow Inventory: " + SnowCollected + "/" + MaxSnow;

    }

    public void UpdateCounter()
    {
        StartCoroutine(WaitForSec());
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(0.5f);
        counter.text = "Snow Inventory: " + SnowCollected + "/" + MaxSnow;

    }
}
