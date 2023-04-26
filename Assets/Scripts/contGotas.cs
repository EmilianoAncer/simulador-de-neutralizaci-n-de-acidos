using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contGotas : MonoBehaviour
{

    public static int gota;
    Text contGota;

    // Start is called before the first frame update
    void Awake()
    {
        gota = 0;
    }
    void Start()
    {
        contGota = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        contGota.text = gota.ToString("0" + "ml");
    }

    public void gotaFunc()
    {
        gota += 1;
    }
    public void resetGota()
    {
        gota = 0;
    }
}
