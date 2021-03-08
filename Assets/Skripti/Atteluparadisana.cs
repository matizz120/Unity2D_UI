using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atteluparadisana : MonoBehaviour
{
    //Uzglabās mūsu bildes no ainas
    public GameObject bins;
    public GameObject lacis;
    public GameObject tante;
    public GameObject mashina;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public AudioSource skanasAvots;
    public AudioClip SkanaKoAtskanot;
 
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

    public void izkritosais(int skaitlis){
        if(skaitlis == 0){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }else if(skaitlis == 1){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }else if(skaitlis == 2){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        }
    }

    public void mainitLielumu(){
        float pasreizejaVert = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F*pasreizejaVert, 1F*pasreizejaVert);
    }
    public void uzbiditsUzAttela(){
        skanasAvots.PlayOneShot(SkanaKoAtskanot);

    }
    public void nobiditsNoAttela(){
        skanasAvots.Stop();
        
    }
}

