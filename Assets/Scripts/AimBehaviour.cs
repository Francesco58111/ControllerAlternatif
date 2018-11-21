using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBehaviour : MonoBehaviour
{

    [Header("Viser")]

    //Récupération du rigidbody
    public Rigidbody2D rb;
    //Set de la vitesse du curseur
    public float aimSpeed = 10;




    void Update()
    {
        //Update de la direction
        if (Input.GetKey(KeyCode.UpArrow))
            Aiming(Vector2.up);
        if (Input.GetKey(KeyCode.DownArrow))
            Aiming(Vector2.down);
        if (Input.GetKey(KeyCode.LeftArrow))
            Aiming(Vector2.left);
        if (Input.GetKey(KeyCode.RightArrow))
            Aiming(Vector2.right);
    }


    /// <summary>
    /// Déplacement du curseur avec son rigidbody
    /// </summary>
    /// <param name="direction"></param>
    public void Aiming(Vector2 direction)
    {
        rb.velocity = direction * aimSpeed * Time.deltaTime;
    }
}
