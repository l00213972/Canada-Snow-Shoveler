using UnityEngine;

public class Selling : MonoBehaviour
{
    public AudioSource source;
    public AudioClip sellSFX;
    private SnowCounter snowCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        snowCounter = FindFirstObjectByType<SnowCounter>(); // Find the snowcounter
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            if (SnowCounter.SnowCollected >= 1)
            {
                if (source != null) 
                    source.PlayOneShot(sellSFX);

                while (SnowCounter.SnowCollected >=1)
                {
                    MapleSyrupCounter.maypleSyrup += SnowCounter.SnowCollected;
                    SnowCounter.SnowCollected = 0;
                    snowCounter.UpdateCounter(); // Call the function
                }
            }
        }
    }
}
