using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atteluparadisana : MonoBehaviour
{
    //Uzglabās mūsu bildes no ainas
    public GameObject bins;
    public GameObject lacis;
    public GameObject tante;
    public GameObject mashina;

    public void binaAttelosana(bool vertiba){
        bins.SetActive(vertiba);
    }

    public void lacisAttelosana(bool vertiba){
        lacis.SetActive(vertiba);
    }

    public void tanteAttelosana(bool vertiba){
        tante.SetActive(vertiba);
    }

    public void mashinaAttelosana(bool vertiba){
        mashina.SetActive(vertiba);
    }
    public void paKreisi(){
        bins.transform.localScale = new Vector2(1, 1);
    }

    public void paLabi(){
        bins.transform.localScale = new Vector2(-1, 1);
    }
}

