using UnityEngine;
using UnityEngine.UI;

public class TraductionText : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public ScriptableTraduccion traduccion;

    public void TextTraduction()
    {
        text1.text = traduccion.text1;
        text2.text = traduccion.text2;
        text3.text = traduccion.text3;
        text4.text = traduccion.text4;
    }
}
