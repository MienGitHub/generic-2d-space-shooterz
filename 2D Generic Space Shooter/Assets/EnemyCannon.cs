using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bulletLayer = gameObject.layer;
    }
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    public GameObject bulletPrefab;
    int bulletLayer;

    public float fireDelay = 0.50f;
    float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if ( cooldownTimer <= 0)
        {
            // FIRE!!!
            Debug.Log("Enemy Pew!");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }

    }
}
