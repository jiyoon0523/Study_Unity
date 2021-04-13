using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anemone : MonoBehaviour, iFlower
{
    private void Start()
    {
        NameFlower();
    }
    public void NameFlower()
    {
        print("Anemone");
        print("This Object is "+ this.gameObject.name);
    }
}
