using System.Collections;
using UnityEngine;

public class SnowMechanic : MonoBehaviour
{
    public int snowLife = 4;
    private SnowCounter snowCounter; // Put the snow counter in here in hiearchy

    private Animator anim_;

    public SpriteRenderer Spr_;

    public Sprite IdleSnow;
    public Sprite SnowStage1;
    public Sprite SnowStage2;
    public Sprite SnowStage3;

    public BoxCollider2D box2d;

    // Audio
    public AudioSource source;
    public AudioClip shovelSFX;
    public AudioClip breakSFX;

    private void Start()
    {
        anim_ = GetComponent<Animator>();
        snowCounter = FindFirstObjectByType<SnowCounter>(); // Find the snowcounter
    }

    public void ChopSnow(int damage)
    {
        snowLife -= damage;

        anim_.SetInteger("Count", snowLife);
        source.PlayOneShot(shovelSFX);

        if (snowLife <= 0)
        {
            anim_.SetBool("Broken", true);
            gameObject.tag = "Untagged";


            if (SnowCounter.SnowCollected < SnowCounter.MaxSnow)
            {
                snowCounter.UpdateCounter(); // Call the function
                SnowCounter.SnowCollected += 1;
            }
            StartCoroutine(WaitABit());
            // box2d.enabled = false;
        }
        Debug.Log(snowLife);

    }

    IEnumerator WaitABit()
    {
        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
    }

}