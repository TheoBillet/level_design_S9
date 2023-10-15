using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class readAction : MonoBehaviour
{
    public GameObject readPanel;
    public int idText = 0;
    public GameObject noteUI;
    private bool playerAround = false;

    private string[] texts = {
        "Facture 1 - Fournitures de Bureau\n\n" +
        "BUREAU DU LOUVRE\n" +
        "Facture N°123456\n" +
        "À l'attention du Service Administratif,\n" +
        "Détails de la commande :\n" +
        "10 rames de papier A4\n"+
        "50 stylos à encre noire\n"+
        "2 boîtes de trombones\n"+
        "1 agrafeuse de bureau\n"+
        "3 pots de colle\n"+
        "Montant total : 85,00 €\n"+
        "Date d'émission : 10 octobre 2023.",
        "Facture 2 - Entretien des Espaces Communs\n"+
        "\n"+
        "BUREAU DU LOUVRE\n"+
        "Facture N°789012\n"+
        "\n"+
        "À l'attention du Service d'Entretien,\n"+
        "Détails de la prestation :\n"+
        "Nettoyage des sanitaires\n"+
        "Entretien des espaces communs\n"+
        "Fourniture et remplacement des ampoules défectueuses\n"+
        "Réparation mineure des chaises de la salle de pause\n"+
        "Montant total : 450,00 €\n"+
        "Date d'émission : 15 octobre 2023\n",
        "Facture 3 - Approvisionnement de la Cafétéria\n" +
        "\n" +
        "BUREAU DU LOUVRE\n" +
        "Facture N°345678\n" +
        "À l'attention du Service de la Cafétéria,\n" +
        "Détails de la commande :\n" +
        "20 kg de café en grains\n" +
        "10 boîtes de thé assorti\n" +
        "50 paquets de biscuits\n" +
        "30 litres de lait\n" +
        "5 boîtes de sucre en poudre\n" +
        "Montant total : 120,00 €\n" +
        "Date d'émission : 20 octobre 2023\n",
        "Tâche : Contrôle des caméras\n" +
        "\n" +
        "Chers Agents de Sécurité,\n" +
        "\n" +
        "Vérifiez toutes les caméras. Signalez les problèmes.\n" +
        "\n" +
        "Superviseur de Sécurité\n",
        "Note Interne - Déplacement de La Joconde\n" +
        "\n" +
        "La Joconde sera déplacée pour rénovation à 23h45 ce soir.\n" +
        "\n" +
        "Cordialement,\n" +
        "La Direction du Louvre\n",
    };
 

    private void Start()
    {
        if (readPanel == null)
        {
            Debug.Log("UI read panel n'est pas renseigné");
        }
        readPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (playerAround)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.read();
            }
        }
    }

    private void read()
    {
        readPanel.SetActive(false);
        noteUI.SetActive(true);
        noteUI.GetComponentsInChildren<TMP_Text>()[0].text = texts[this.idText];
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerAround = true;
            readPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerAround = false;
            readPanel.SetActive(false);
            noteUI.SetActive(false);
        }
    }
}
