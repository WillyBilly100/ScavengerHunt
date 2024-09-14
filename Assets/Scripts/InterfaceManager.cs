using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InterfaceManager : MonoBehaviour
{
    public GameObject dialogBox;
    public TMP_Text dialogText;
    //public TMP_Text Test;
    public Image seekImage;
    public GameObject npc;
    public GameObject randomSpawn;
    //public TMP_Text dialogText;

    /*public void SetDialogue(string text){
        if(dialogueText != null){
            dialogueText.text = text;
        }
    }*/

    [SerializeField]
    private Sprite[] collectibleSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CollectibleUpdate(int item)
    {

    }

    public void ShowBox(string dialog, int item)
    {
        if (npc.GetComponent<DialogOpen>().begin)
        {
            scatterCoins();
        }
    }

    public void scatterCoins()
    {
        randomSpawn.GetComponent<RandomSpawn>().DistributeCollectibles();
        npc.GetComponent<DialogOpen>().coinsScattered();
    }
}
