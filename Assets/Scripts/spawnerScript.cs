using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerScript : MonoBehaviour
{
    public GameObject gotaPrefab;
    public Button bureta;

    void Start()
    {
        bureta.onClick.AddListener(SpawnGota);    
    }

    void SpawnGota()
    {
        GameObject newGota = Instantiate(gotaPrefab, transform.position, Quaternion.identity);
        Destroy(newGota, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gotaPrefab, transform.position, Quaternion.identity);
        }
    }
}
