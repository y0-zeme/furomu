using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightcon : MonoBehaviour
{
    public GameObject flashLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            flashLight.SetActive(!flashLight.activeSelf);
        }
    }
}
