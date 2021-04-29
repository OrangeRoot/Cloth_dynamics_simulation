using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_button : MonoBehaviour
{
    public GameObject main_button;

    public GameObject button_cloth_0;
    public GameObject button_cloth_1;
    public GameObject button_cloth_2;
    public GameObject button_cloth_3;
    public GameObject size_slider;
    public GameObject stiffness_slider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void menu_click()
    {
        //main_button.SetActive(false);

        if (button_cloth_0.activeInHierarchy == false)
        {
            button_cloth_0.SetActive(true);
            button_cloth_1.SetActive(true);
            button_cloth_2.SetActive(true);
            button_cloth_3.SetActive(true);
            size_slider.SetActive(true);
            stiffness_slider.SetActive(true);
        }
        else
        {

            button_cloth_0.SetActive(false);
            button_cloth_1.SetActive(false);
            button_cloth_2.SetActive(false);
            button_cloth_3.SetActive(false);
            size_slider.SetActive(false);
            stiffness_slider.SetActive(false);
        }
        




    }

}
