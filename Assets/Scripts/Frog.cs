using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{

    public float upForce = 300f;

    private bool isDead = false;
    private Rigidbody2D  body;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == false)
        {
            if(Input.GetKeyDown ("space"))
            {
                body.velocity = Vector2.zero;
                body.AddForce(new Vector2(0,upForce));
                anim.SetTrigger("Jump");
            }
        }

    
    }
    void OnCollisionEnter2D ()
    {
        isDead = true;
        anim.SetTrigger("Dead");
        GameController.instance.FrogDied();
    }
}
