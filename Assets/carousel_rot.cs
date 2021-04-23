using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carousel_rot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(.05f, 0f, 0f);
        this.transform.Rotate(0f, 0f, 1f);
        this.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
