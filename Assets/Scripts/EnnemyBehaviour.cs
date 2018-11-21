using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBehaviour : MonoBehaviour
{

    public Rigidbody ennemyRigidbody;

    public float ennemySpeed = 100;


    
    void Update()
    {
        EnnemyMove();
    }

    private void EnnemyMove()
    {
        ennemyRigidbody.velocity = Vector3.back * ennemySpeed * Time.deltaTime;
    }

}
