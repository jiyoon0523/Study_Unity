using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject flowerObj;
    iFlower iflower;

    // Start is called before the first frame update
    void Start()
    {
        flowerObj = GameObject.FindGameObjectWithTag("flower");
        iflower= flowerObj.GetComponent<iFlower>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            iflower.NameFlower();
            //flowerObj.GetComponent<iFlower>().NameFlower();
        }
    }
}
