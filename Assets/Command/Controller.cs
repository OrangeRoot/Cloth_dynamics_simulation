using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CommandPattern
{
    public class Controller : MonoBehaviour
    {
        public Button Cloth_0_Button;
        public Button Cloth_1_Button;
        public Button Cloth_2_Button;
        public Button Cloth_3_Button;
        public Clothes clothes;

        //commands connected to clothes
        private Command clothNo0;
        private Command clothNo1;
        private Command clothNo2;
        private Command clothNo3;

        void Start()
        {
            clothNo0 = new Cloth_0(clothes);
            clothNo1 = new Cloth_1(clothes);
            clothNo2 = new Cloth_2(clothes);
            clothNo3 = new Cloth_3(clothes);

        }


        void Update()
        {
            Cloth_0_Button.onClick.AddListener(clothNo0.Execute);
            Cloth_1_Button.onClick.AddListener(clothNo1.Execute);
            Cloth_2_Button.onClick.AddListener(clothNo2.Execute);
            Cloth_3_Button.onClick.AddListener(clothNo3.Execute);
        }
    }
}