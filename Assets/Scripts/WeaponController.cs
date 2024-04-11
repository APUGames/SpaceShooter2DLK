using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject prefab;
    public Transform rifleTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion quaternion = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(prefab, rifleTransform.position, quaternion);
        }
    }
}
