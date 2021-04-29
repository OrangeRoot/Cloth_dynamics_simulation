using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CommandPattern
{
    public class Cloth_0 : Command
    {
        private Clothes clothes;

        public Cloth_0(Clothes clothes)
        {
            this.clothes = clothes;
        }


        public override void Execute()
        {
            clothes.Cloth0();

        }

    }
}