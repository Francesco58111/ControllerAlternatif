using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public GameObject viseur;
    public GameObject player;

    public float speed;
    public float durability = 1;
    public float damage = 1;
    public float lifeTime = 10;

    public Vector3 viseurPosition;



    void Awake()
    {
        Destroy(this.gameObject, lifeTime);
        viseur = GameObject.Find("AimTarget");
        player = GameObject.Find("Player");
        viseurPosition = new Vector3(viseur.transform.position.x, viseur.transform.position.y, viseur.transform.position.z) - new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z) ; 
    }

    public void Update()
    {
        transform.Translate(viseurPosition * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}
