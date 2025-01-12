using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Color cubeColor;
    public string colorName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision collision)
    {
        if
(collision.gameObject.CompareTag("Bullet"))
        {
            DisplayColor();
            Destroy(collision.gameObject);
        }
    }
    void DisplayColor()
    {
        Debug.Log("Hit color: " + colorName);
    }
}
