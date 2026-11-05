using TMPro;
using UnityEngine;

public class MapleSyrupCounter : MonoBehaviour
{
    public static int maypleSyrup;

    public TextMeshProUGUI counter; // UI Counter

    private void Start()
    {
        maypleSyrup = 0;
    }

    private void Update()
    {
        counter.text = "Maple Syrup Collected: " + maypleSyrup;
    }
}
