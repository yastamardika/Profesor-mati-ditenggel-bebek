using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("tewas");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            v.y = 1;
            animator.SetInteger("ver", 1);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -1;
            animator.SetInteger("hor", -1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = 1;
            animator.SetInteger("hor", 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v.y = -1;
            animator.SetInteger("ver", -1);
        }

        if (v== Vector2.zero)
        {
            animator.SetInteger("hor", 0);
            animator.SetInteger("ver", 0);
        }
        float speed=2 *Time.deltaTime;
        transform.Transform(speed);
    }
}
