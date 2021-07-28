using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollision : MonoBehaviour
{

    public int health = 1;

    public float invulnperiod = 0;
    float invulnTimer = 0;
    int correctLayer;

    SpriteRenderer spriteRend;

    void Start()
    {
        correctLayer = gameObject.layer;

        //spriteRend = GetCompnent<SpriteRenderer>();

        //if(spriteRend == null)
        //{
        //    Debug.LogError("Object '" + gameobject.name + "' has no sprite renderer.");
        //}
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        health--;
        invulnTimer = 0.50f;
        gameObject.layer = 7;

    }

    void Update()
    {
        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0)
        {
            gameObject.layer = correctLayer;
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}
