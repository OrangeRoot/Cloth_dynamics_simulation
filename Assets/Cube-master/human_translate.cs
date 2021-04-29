using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human_translate : MonoBehaviour
{

    public GameObject Human;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void fix_position()
    {
        Human.transform.position = new Vector3(0f, 0f, 0f);
    }


}
