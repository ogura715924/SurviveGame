using System.Collections;
using System.Collections.Generic;
using UniGLTF;
using UnityEngine;

public class HunikoScript : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;
    public GameObject bulletHart;
    public GameObject gameManager;

    private float moveSpeed = 5.0f;
    private float bulletHartTimer = 0;

    private BulletHartScript bulletScript;
    private GameManagerScript gameManagerScript;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        transform.rotation = Quaternion.Euler(0, 180, 0);
        gameManagerScript = gameManager.GetComponent<GameManagerScript>();
    }

    void Update()
    {
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
            rb.velocity = new Vector3(0, 0, moveSpeed);
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0, -moveSpeed);
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            rb.velocity=new Vector3 (0, 0, 0);
            animator.SetBool("Run", false);
        }
    }

    void FixedUpdate()
    {
        Vector3 position = transform.position + transform.forward * 1.0f;
        //’e‚ÌŒü‚«•Ï‚¦‚æ‚¤‚Æ‚µ‚½‚â‚Â
        Quaternion rotation = transform.rotation;
        position.y += 0.8f;
        position.z += 1.0f;

        if (bulletHartTimer == 0)
        {
            GameObject bullet = Instantiate(bulletHart, position,rotation);
            bulletScript = bullet.GetComponent<BulletHartScript>();
            bulletScript.SetDirection(transform.forward);
            bulletHartTimer = 1;
        }

        if (bulletHartTimer != 0)
        {
            bulletHartTimer++;
            if (bulletHartTimer > 20)
            {
                bulletHartTimer = 0;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameManagerScript.GameOverStart();
            Destroy(other.gameObject);
        }
    }
}
