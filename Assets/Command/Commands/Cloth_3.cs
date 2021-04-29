using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class Cloth_3 : Command
    {
        private Clothes clothes;
 
        public Cloth_3(Clothes clothes)
        {
            this.clothes = clothes;
        }


        public override void Execute()
        {
            clothes.Cloth3();

        }

    }
}