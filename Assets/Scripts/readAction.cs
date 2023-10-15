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
        "Facture N�123456\n" +
        "� l'attention du Service Administratif,\n" +
        "D�tails de la commande :\n" +
        "10 rames de papier A4\n"+
        "50 stylos � encre noire\n"+
        "2 bo�tes de trombones\n"+
        "1 agrafeuse de bureau\n"+
        "3 pots de colle\n"+
        "Montant total : 85,00 �\n"+
        "Date d'�mission : 10 octobre 2023.",
        "Facture 2 - Entretien des Espaces Communs\n"+
        "\n"+
        "BUREAU DU LOUVRE\n"+
        "Facture N�789012\n"+
        "\n"+
        "� l'attention du Service d'Entretien,\n"+
        "D�tails de la prestation :\n"+
        "Nettoyage des sanitaires\n"+
        "Entretien des espaces communs\n"+
        "Fourniture et remplacement des ampoules d�fectueuses\n"+
        "R�paration mineure des chaises de la salle de pause\n"+
        "Montant total : 450,00 �\n"+
        "Date d'�mission : 15 octobre 2023\n",
        "Facture 3 - Approvisionnement de la Caf�t�ria\n" +
        "\n" +
        "BUREAU DU LOUVRE\n" +
        "Facture N�345678\n" +
        "� l'attention du Service de la Caf�t�ria,\n" +
        "D�tails de la commande :\n" +
        "20 kg de caf� en grains\n" +
        "10 bo�tes de th� assorti\n" +
        "50 paquets de biscuits\n" +
        "30 litres de lait\n" +
        "5 bo�tes de sucre en poudre\n" +
        "Montant total : 120,00 �\n" +
        "Date d'�mission : 20 octobre 2023\n",
        "T�che : Contr�le des cam�ras\n" +
        "\n" +
        "Chers Agents de S�curit�,\n" +
        "\n" +
        "V�rifiez toutes les cam�ras. Signalez les probl�mes.\n" +
        "\n" +
        "Superviseur de S�curit�\n",
        "Note Interne - D�placement de La Joconde\n" +
        "\n" +
        "La Joconde sera d�plac�e pour r�novation � 23h45 ce soir.\n" +
        "\n" +
        "Cordialement,\n" +
        "La Direction du Louvre\n",
    };
 

    private void Start()
    {
        if (readPanel == null)
        {
            Debug.Log("UI read panel n'est pas renseign�");
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
