using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i = 0;
    public Renderer rend;

    public int random = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }

        Debug.Log(gameObject.name + ":" + i);
        i++;
    }
}
