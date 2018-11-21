using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    [Header("Déplacement")]

    public float speed = 10f; // Vitesse de déplacement
    public float shootingReload;

    //Coordonnées de chaque colonne du niveau
    public Vector3 premier;
    public Vector3 second;
    public Vector3 third;

    private Vector3 targetPosition;

    //Variables ajoutées par Emilie
    public GameObject bulletPrefab;
    public GameObject player;

    Vector3 playerPosition;



    void Start()
    {
        premier = new Vector3(-3, 0, 0);
        second = new Vector3(0.1f, 0, 0);
        third = new Vector3(3, 0, 0);
    }



    void Update()
    {

        PlayerMove();

        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(Tir());
        }

        

    }

    /// <summary>
    /// Déplacement du joueur actualisé selon l'Input
    /// </summary>
    public void PlayerMove()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Left");
            targetPosition = premier;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("Middle");
            targetPosition = second;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Right");
            targetPosition = third;
        }

        if (targetPosition == transform.position)
            return;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }


    IEnumerator Tir()
    {
        Instantiate<GameObject>(bulletPrefab, playerPosition, Quaternion.identity);
        yield return new WaitForSeconds(shootingReload);
    }
}
