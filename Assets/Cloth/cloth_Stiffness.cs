using UnityEngine;
using UnityEngine.UI;

public class cloth_Stiffness : MonoBehaviour
{

    public Slider stiffness;
    public void change_stiffness()
    {
        GetComponent<Cloth>().stretchingStiffness = stiffness.value;
    }
}