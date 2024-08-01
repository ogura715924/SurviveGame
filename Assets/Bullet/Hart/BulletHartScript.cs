using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHartScript : MonoBehaviour
{
    public Rigidbody rb;

    private Vector3 PlayerDirection;
    private float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = PlayerDirection * moveSpeed;
        Destroy(gameObject, 5);

        transform.rotation = Quaternion.Euler(270, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }


    // íeÇÃï˚å¸Çê›íËÇ∑ÇÈÇΩÇﬂÇÃÉÅÉ\ÉbÉh
    public void SetDirection(Vector3 forward)
    {
        PlayerDirection = forward;
    }

}
