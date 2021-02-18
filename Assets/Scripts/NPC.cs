using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
   [SerializeField]
   TextBox npcTextBox;

   [SerializeField]
   string npmDialog;

 


   public void Startalking()
   {
       npcTextBox.gameObject.SetActive(true);
        npcTextBox.Message = npmDialog;
         npcTextBox.ShowDialog();

   }

   public void StopTalking()
   {
        npcTextBox.gameObject.SetActive(false);

        npcTextBox.ClearText();
   }

    void OnTriggerEnter(Collider other) {
       if (other.CompareTag("Player"))
       {
           Startalking();
       }
   }

       void OnTriggerExit(Collider other) {
       if (other.CompareTag("Player"))
       {
           StopTalking();
       }
   }


}
