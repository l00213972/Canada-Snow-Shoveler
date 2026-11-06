using UnityEngine;

public class UIButton : MonoBehaviour
{
    public GameObject canva;
    private bool isPressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canva.SetActive(false); // Set the game shop UI to off
        isPressed = false;
    }

    public void OpenCloseShop()
    {
        isPressed = !isPressed; // Toggle the boolean

        canva.SetActive(isPressed);
    }
}
