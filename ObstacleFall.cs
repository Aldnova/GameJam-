using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    bool isMove = true;
    public float movementSpeed = 5f;

    void Update()
    {
        if (isMove)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            isMove = false;
        }
    }
}
