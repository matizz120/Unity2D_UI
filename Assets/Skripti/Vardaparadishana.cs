using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāieimportē, lai varētu strādāt ar UI elementiem
using UnityEngine.UI;

public class Vardaparadishana : MonoBehaviour{
    //Mainīgajā saglabās tekstu, ko raksta teksta laukā
    public string teksts;
    //Lauks, kura ieraksta tekstu
    public GameObject ievadeslauks1;
    //attēlo tekstu
    public GameObject tekstaAtteloshana;

    //Funkcija tiek izsaukta nospiežot pogu
    public void uzglabatTekstu(){
        teksts = ievadeslauks1.GetComponent<Text>().text;
        tekstaAtteloshana.GetComponent<Text>().text = "Sveiks, "+teksts.ToUpper() + "!";
    }

}
