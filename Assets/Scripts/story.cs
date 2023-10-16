using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class story : MonoBehaviour
{
    private string text =
        "Dans ce niveau, vous avez pour mission de sauver une pr�cieuse �uvre d'art du Louvre.\n" +
        "Des trafiquants d'art avec pour complice le directeur du Louvre, pr�voient de la voler et de la remplacer par une copie.\n" +
        "Pour �viter ce triste sort, vous devez agir rapidement, car la vente de l'�uvre aux trafiquants est pr�vue pour cette nuit.\n" + 
        "Pour accomplir cette mission d�licate, vous avez acquis une nouvelle arme secr�te : un pistolet �lectromagn�tique. " +
        "Cette technologie avanc�e vous permet de d�sactiver discr�tement les cam�ras de s�curit�, �l�ment cl� pour progresser dans le mus�e sans �tre rep�r�.";
    
    public TMP_Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        if (textUI == null)
        {
            Debug.Log("text UI non mi sur story UI");
        }
    }

    // Update is called once per frame
    void Update()
    {
        textUI.SetText(text);
    }

    public void launchGame ()
    {
        SceneManager.LoadScene("MainScene");
    }
}
