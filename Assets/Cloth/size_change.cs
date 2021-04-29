using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class size_change : MonoBehaviour
{

    public GameObject cloth_1;
    public GameObject cloth_2;
    public GameObject cloth_3;
    public GameObject long_skirt;

    public GameObject[] bra_size;

    public Slider slider_size;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }


    public void resize()
    {
        if (cloth_1.activeInHierarchy == true)
        {
            cloth_1.SetActive(false);
            cloth_1.transform.localScale = new Vector3(90f, 95f, 100f + 8f * slider_size.value);
            cloth_1.SetActive(true);
        }
        if (bra_size[10].activeInHierarchy == true)
        {
            bra_size[10].SetActive(false);
            for (int i = 0; i < 10; i++)
            {

                bra_size[i].transform.localScale = new Vector3(0.04f, 0.04f, 0.03f + 0.005f * slider_size.value);

            }
            bra_size[10].SetActive(true);
        }
        if (long_skirt.activeInHierarchy == true)
        {
            long_skirt.SetActive(false);
            long_skirt.transform.localScale = new Vector3(1.03f, 1.05f, 0.53f + 0.1f * slider_size.value);
            long_skirt.SetActive(true);

        }






    }
}

