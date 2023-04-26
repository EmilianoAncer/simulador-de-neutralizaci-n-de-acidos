using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matraz : MonoBehaviour
{

    public int miliLit = 0;

    Color basee = new Color(0.7254902f, 0.9803922f, 0.972549f, 1.0f); // rgba Cambiar al color ideal opacidad 0.6862745f
    Color ideal = new Color(0.6980392f, 0.6705883f, 0.9490196f, 1.0f); // rgba Cambiar al color ideal
    Color error = new Color(0.6980392f, 0.432f, 0.9490196f, 1.0f); // rgba Cambiar al color error basandote en color de unity

    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = basee;
    }

    // Update is called once per frame
    void Update()
    {
        if(miliLit == 20)
        {
            if (contGotas.gota == 10)
            {
                image.color = ideal;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
            }
        }
        if (miliLit == 40)
        {
            if (contGotas.gota == 10)
            {
                image.color = ideal;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
            }
        }
        if (miliLit == 60)
        {
            if (contGotas.gota == 10)
            {
                image.color = ideal;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
            }
        }
        if (miliLit == 80)
        {
            if (contGotas.gota == 10)
            {
                image.color = ideal;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
            }
        }
        if (miliLit == 100)
        {
            if (contGotas.gota == 10)
            {
                image.color = ideal;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
            }
        }
        if (miliLit == 120)
        {
            if (contGotas.gota == 10)
            {
                image.color = ideal;
            }
            if (contGotas.gota >= 11)
            {
                image.color = error;
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
}
