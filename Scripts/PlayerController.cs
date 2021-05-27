using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public bool canControl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canControl == true)
        {
            float h = Input.GetAxis("Horizontal") * Speed;
            transform.Translate(h * Time.deltaTime, 0, 0);
        }
    }
}