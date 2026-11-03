using System.Collections;
using UnityEngine;

public class SnowMechanic : MonoBehaviour
{
    public int snowLife = 4;

    private Animator anim_;

    public SpriteRenderer Spr_;

    public Sprite IdleSnow;
    public Sprite SnowStage1;
    public Sprite SnowStage2;
    public Sprite SnowStage3;

    public BoxCollider2D box2d;

    private void Start()
    {
        anim_ = GetComponent<Animator>();
    }

    public void ChopSnow(int damage)
    {
        snowLife -= damage;

        anim_.SetInteger("Count", snowLife);

        if (snowLife <= 0)
        {
            anim_.SetBool("Broken", true);

            StartCoroutine(WaitABit());
            // box2d.enabled = false;
        }
        Debug.Log(snowLife);

    }

    IEnumerator WaitABit()
    {
        yield return new WaitForSeconds(0.6f);

        Destroy(gameObject);
    }

}