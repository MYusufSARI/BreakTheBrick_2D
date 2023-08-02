using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AltDuvar : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D diger)
    {
        if (true)
        {
            diger.gameObject.name.Equals("top");

            SceneManager.LoadScene("OyunuKaybettiniz");

        }
    }
}
