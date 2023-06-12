using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matraz : MonoBehaviour
{

    public int miliLit = 0;

    Color basee = new Color(0.7254902f, 0.9803922f, 0.972549f, 1.0f); // rgba Cambiar al color ideal opacidad 0.6862745f
    Color pasa = new Color(0.6980392f, 0.77f, 0.9490196f, 1.0f); // rgba Cambiar al color ideal opacidad 0.6862745f
    Color ideal = new Color(0.6980392f, 0.6705883f, 0.9490196f, 1.0f); // rgba Cambiar al color ideal
    Color error = new Color(0.6980392f, 0.432f, 0.9490196f, 1.0f); // rgba Cambiar al color error basandote en color de unity

    private Image image;

    public GameObject good;
    public GameObject bad;

    public bool valido = false;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = basee;
        valido = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(miliLit == 20)
        {
            if (contGotas.gota == 3 || contGotas.gota == 4)
            {
                image.color = pasa;
            }
            if (contGotas.gota == 5)
            {
                image.color = ideal;
                valido = true;
            }
            if (contGotas.gota >= 6)
            {
                image.color = error;
                valido = false;
            }
        }
        if(miliLit == 40)
        {
            if (contGotas.gota == 8 || contGotas.gota == 9)
            {
                image.color = pasa;
            }
            if (contGotas.gota == 10)
            {
                image.color = ideal;
                valido = true;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
                valido = false;
            }
        }
        if(miliLit == 60)
        {
            if (contGotas.gota == 13 || contGotas.gota == 14)
            {
                image.color = pasa;
            }
            if (contGotas.gota == 15)
            {
                image.color = ideal;
                valido = true;
            }
            if (contGotas.gota >= 16)
            {
                image.color = error;
                valido = false;
            }
        }
        if(miliLit == 80)
        {
            if (contGotas.gota == 18 || contGotas.gota == 19)
            {
                image.color = pasa;
            }
            if (contGotas.gota == 20)
            {
                image.color = ideal;
                valido = true;
            }
            if (contGotas.gota >= 21)
            {
                image.color = error;
                valido = false;
            }
        }
        if(miliLit == 100)
        {
            if (contGotas.gota == 23 || contGotas.gota == 24)
            {
                image.color = pasa;
            }
            if (contGotas.gota == 25)
            {
                image.color = ideal;
                valido = true;
            }
            if (contGotas.gota >= 26)
            {
                image.color = error;
                valido = false;
            }
        }
        if(miliLit == 120)
        {
            if (contGotas.gota == 28 || contGotas.gota == 29)
            {
                image.color = pasa;
            }
            if (contGotas.gota == 30)
            {
                image.color = ideal;
                valido = true;
            }
            if (contGotas.gota >= 31)
            {
                image.color = error;
                valido = false;
            }
        }

    }


    public void mililitros(int mili)
    {
        miliLit = mili;
    }
    public void resetSprite()
    {
        image.color = basee;
    }
    public void validar(){
        if(valido == true){
            good.SetActive(true);
        }else{
            bad.SetActive(true);
        }
    }
}
