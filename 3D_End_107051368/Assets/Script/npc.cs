using UnityEngine; 
using UnityEngine.UI;
using System.Collections;

public class npc : MonoBehaviour
{
    public NPCData data;
    public GameObject dialog;
    public Text textContent;
    public Text textName;
    public float interval = 0.2f;

    public enum npcstate
    {
        FirstDialog, Missioning,Finish
    }

    public npcstate state = npcstate.FirstDialog;
    public bool playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Hero")
        {
            playerInArea = true;
            StartCoroutine(Dialog());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Hero")
        {
            playerInArea = false;
            StopDialog();
        }
    }

    private void StopDialog()
    {
        dialog.SetActive(false);
        StopAllCoroutines();
    }

    private IEnumerator Dialog()
    {
        dialog.SetActive(true);
        textContent.text = "";
        textName.text = name;

        string dialogString = data.dialogA;

        switch (state)
        {
            case npcstate.FirstDialog:
                dialogString = data.dialogA;
                break;
            case npcstate.Missioning:
                dialogString = data.dialogB;
                break;
            case npcstate.Finish:
                dialogString = data.dialogC;
                break;
        }

        for (int i = 0; i < dialogString.Length; i++)
        {
            textContent.text += dialogString[i] + "";
            yield return new WaitForSeconds(interval);
        }
    }
}
