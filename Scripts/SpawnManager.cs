using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    // Start is called before the first frame update
    void Start()
    {
        for (float i=-2.5f; i<3; i = i + 1)
        {
            Vector2 position1 = new Vector2(i,1);
            Vector2 position2 = new Vector2(i,2);
            Vector2 position3 = new Vector2(i,3);
            Instantiate(enemy1,position1,enemy1.transform.rotation);
            Instantiate(enemy2,position2,enemy2.transform.rotation);
            Instantiate(enemy3,position3,enemy3.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
