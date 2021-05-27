using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform projectileSpawn;
    public float nextFire = 0.1f;
    public float currentTime = 0.0f;
    public GameObject projectile;
   
    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }
    public void shooting()
    {
        currentTime += Time.deltaTime;
       
        if(Input.GetKey(KeyCode.Space) && currentTime > nextFire)
        {
            nextFire += currentTime;
            Instantiate (projectile, transform.position, Quaternion.identity); //shoot and create the shot.
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}