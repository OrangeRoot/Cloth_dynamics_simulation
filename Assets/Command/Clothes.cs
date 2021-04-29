using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace CommandPattern
{
    //This class handles all methods that change clothes
    public class Clothes : MonoBehaviour
    {
        public GameObject cenzura;

        public GameObject cloth_1;
        public GameObject cloth_1_size;
        public GameObject cloth_2;
        public GameObject cloth_3;
        public GameObject size_slider;
        public Slider reset_slider;

        public GameObject stiffness_slider;


        //These methods will be executed by their own command
        public void Cloth0()
        {
            cloth_1.SetActive(false);
            cloth_2.SetActive(false);
            cloth_3.SetActive(false);
            size_slider.SetActive(false);
            reset_slider.value = 0f;
            cenzura.SetActive(true);
            stiffness_slider.SetActive(false);
        }

        public void Cloth1()
        {
            cloth_1.SetActive(true);
            cloth_2.SetActive(false);
            cloth_3.SetActive(false);
            reset_slider.value = 0f;
            size_slider.SetActive(true);
            cenzura.SetActive(false);
            stiffness_slider.SetActive(true);
        }

        public void Cloth2()
        {
            cloth_1.SetActive(false);
            cloth_2.SetActive(true);
            cloth_3.SetActive(false);
            reset_slider.value = 0f;
            size_slider.SetActive(true);
            cenzura.SetActive(false);
            stiffness_slider.SetActive(true);
        }

        public void Cloth3()
        {
            cloth_1.SetActive(false);
            cloth_2.SetActive(false);
            cloth_3.SetActive(true);
            reset_slider.value = 0f;
            size_slider.SetActive(true);
            cenzura.SetActive(false);
            stiffness_slider.SetActive(true);
        }

    }
}
