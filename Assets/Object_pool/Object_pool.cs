using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Object_poolPattern
{

    public class Object_pool : MonoBehaviour
    {

        private GameObject enviroment;
        private GameObject[] enviroment_tab = new GameObject[8];


        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < 8; i++)
            {
                string name = $"enviroment{i}";
                enviroment_tab[i] = GameObject.Find(name);
            }
            enviroment_tab[6].SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            float max_x = 0;
            for (int i = 0; i < 8; i++)
            {
                if (enviroment_tab[i].transform.position[0] > max_x)
                {
                    max_x = enviroment_tab[i].transform.position[0];
                }
            }


            if (max_x < 97.7)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (enviroment_tab[i].activeInHierarchy == false)
                    {
                        enviroment_tab[i].transform.position = new Vector3(136.9f, 0f, 8.77f);
                        enviroment_tab[i].SetActive(true);
                        break;
                    }
                }
                for (int i = 0; i < 8; i++)
                {

                    if (enviroment_tab[i].transform.position[0] < -119)
                    {
                        enviroment_tab[i].SetActive(false);
                    }
                }
            }

        }

    }
}
