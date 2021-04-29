using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MementoPattern
{

    public class Memento
    {

        public int save_kal;
        public GameObject[] Game_tab;

        public Memento(int sk, GameObject[] game_tab)
        {
            this.save_kal = sk;
            this.Game_tab = game_tab;

        }

    }

    public class Saver
    {
        public Memento SaveK;
    }



    public class AnimSave
    {
        public int save_kal;
        public int old_kal;
        public GameObject[] Game_tab = new GameObject[8];
        public GameObject[] Game_tab_new = new GameObject[8];
        public bool envir;

        public Memento CreateMarker(AnimSave animacja)
        {
            return new Memento(animacja.save_kal, animacja.Game_tab_new);
        }

        public void RestoreAnim(Memento reMemento, int i)
        {
            this.save_kal = reMemento.save_kal;
            this.Game_tab_new = reMemento.Game_tab;
            this.old_kal = (int)Time.fixedTime;
            this.Game_tab[i].transform.localPosition = Game_tab_new[i].transform.localPosition;
            this.Game_tab[i].SetActive(envir);
        }
    }




    public class momento : MonoBehaviour
    {

        public Text kalorie;
        private int new_kal = 0;
        public GameObject enviroment0;
        public GameObject enviroment1;
        public GameObject enviroment2;
        public GameObject enviroment3;
        public GameObject enviroment4;
        public GameObject enviroment5;
        public GameObject enviroment6;
        public GameObject enviroment7;

        private bool[] enviroment_visi = new bool[] { true, true, true, true, true, true, false, true };



        private GameObject go;

        AnimSave animSave = new AnimSave();
        Saver saver = new Saver();

        void Start()
        {
            animSave.Game_tab = new GameObject[] { enviroment0, enviroment1, enviroment2, enviroment3, enviroment4, enviroment5, enviroment6, enviroment7 };
            save();
        }

        void Update()
        {
            int czas = (int)Time.fixedTime + new_kal - animSave.old_kal;
            kalorie.text = $"Spalone kalorie: {czas.ToString()}";

        }

        public void save()
        {


            for (int i = 0; i < animSave.Game_tab.Length; i++)
            {
                enviroment_visi[i] = animSave.Game_tab[i].activeInHierarchy;
                Destroy(animSave.Game_tab_new[i]);
                go = GameObject.Instantiate(animSave.Game_tab[i]);
                animSave.Game_tab_new[i] = go;
                go.SetActive(false);

                animSave.save_kal = (int)Time.fixedTime - animSave.old_kal + new_kal; ;
                saver.SaveK = animSave.CreateMarker(animSave);
            }
        }


        public void reset()
        {

            for (int i = 0; i < animSave.Game_tab.Length; i++)
            {
                animSave.envir = enviroment_visi[i];
                animSave.RestoreAnim(saver.SaveK, i);
                new_kal = animSave.save_kal;
            }
        }

    }
}
