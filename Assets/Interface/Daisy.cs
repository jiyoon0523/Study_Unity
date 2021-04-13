using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daisy : MonoBehaviour, iFlower
{
    private void Start()
    {
        NameFlower();
    }
    public void NameFlower()
    {
        print("Daisy");
        print("This Object is " + this.gameObject.name);
    }
}
