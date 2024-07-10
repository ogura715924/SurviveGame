using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunikoScript : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;

    private float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //à⁄ìÆ(UpdateÇ…èëÇ≠Ç◊Ç´ÇæÇØÇ«Ç»Ç∫Ç©à⁄ìÆÇ≈Ç´Ç»Ç≠Ç»ÇÈÇ©ÇÁÇ¢àÍéûìIÇ…Ç±Ç±)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(moveSpeed, 0, 0);
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-moveSpeed, 0, 0);
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0, 0,moveSpeed);
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0,-moveSpeed);
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
            animator.SetBool("Run", false);
        }
    }
}
