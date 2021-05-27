using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.up * Time.deltaTime * 12);
    }
    void OnTriggerEnter() 
    {
        Destroy(gameObject);
    }
}
