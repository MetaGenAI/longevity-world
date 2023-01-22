using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

public class MyButton : UdonSharpBehaviour
{
    public Text Text;
    public GameObject WallToDisable;
    
    public void OnClick()
    {
        Text.text = "yee";
        WallToDisable.SetActive(false);
    }
}
