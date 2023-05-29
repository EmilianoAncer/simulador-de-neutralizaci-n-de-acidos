using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneName;

    public bool Herramienta1 = false;
    public bool Herramienta2 = false;
    public bool Herramienta3 = false;
    public bool Herramienta4 = false;


    // Start is called before the first frame update
    void Start()
    {
        Herramienta1 = false;
        Herramienta2 = false;
        Herramienta3 = false;
        Herramienta4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeScene()
    {
        if(Herramienta1 == true && Herramienta2 == true && Herramienta3 == true && Herramienta4 == true)
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }

    public void setTrue(int exa)
    {
        if(exa == 1)
        {
            Herramienta1 = true;
        }else if (exa == 2)
        {
            Herramienta2 = true;
        }
        else if(exa == 3)
        {
            Herramienta3 = true;

        }else if (exa == 4)
        {
            Herramienta4 = true;
        }
    }

}
