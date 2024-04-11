using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public int yspeed = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, yspeed * Time.deltaTime, 0);
        if (gameObject.transform.position.y > 20)
        {
            Destroy(gameObject);
        }
    }
}
