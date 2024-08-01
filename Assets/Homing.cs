using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{
    public Transform position;//目標の位置
    public float moveSpeed = 1.0f;

    void Update()
    {
        if (position != null)
        {
            //目標の位置に向く
            transform.LookAt(position);

            //目標に向かって移動
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
