using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class TextBox : MonoBehaviour
{
    [SerializeField]
    Text text;

    [SerializeField]
    string message;

    public void ShowDialog()
    {
        animatetext = Animate(0.1f);
        StartCoroutine(animatetext);
    }

    public void ClearText()
    {
        text.text  = "";
    }
    IEnumerator animatetext;

    public string Message {get => message; set => message = value;}
    
        IEnumerator Animate(float time)
    {
        int i = 0;
        while(i < Message.Length - 1)
        {
            text.text += message[i];
            i++;
            yield return new WaitForSeconds(time);
        }
    }
}
