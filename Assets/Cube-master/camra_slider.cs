using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camra_slider : MonoBehaviour
{
    public Slider slider_cam;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void camera_transform()
    { 
        float alpha = slider_cam.value/180;
        Camera.transform.position = new Vector3(2 * Mathf.Cos(alpha * Mathf.PI), 1.1f, 2 * Mathf.Sin(alpha * Mathf.PI));


        Camera.transform.rotation = Quaternion.Euler(11, -alpha*180 -90, 0);
    }
}
