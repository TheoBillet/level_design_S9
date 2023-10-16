using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class story : MonoBehaviour
{
    private string text =
        "Dans ce niveau, vous avez pour mission de sauver une précieuse œuvre d'art du Louvre.\n" +
        "Des trafiquants d'art avec pour complice le directeur du Louvre, prévoient de la voler et de la remplacer par une copie.\n" +
        "Pour éviter ce triste sort, vous devez agir rapidement, car la vente de l'œuvre aux trafiquants est prévue pour cette nuit.\n" + 
        "Pour accomplir cette mission délicate, vous avez acquis une nouvelle arme secrète : un pistolet électromagnétique. " +
        "Cette technologie avancée vous permet de désactiver discrètement les caméras de sécurité, élément clé pour progresser dans le musée sans être repéré.";
    
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
