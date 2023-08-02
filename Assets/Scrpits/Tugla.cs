using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public static int toplamTuglaSayisi; 
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
  

    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        
    }





    void OnCollisionEnter2D(Collision2D diger)
    {
        if (diger.gameObject.name.Equals("top"))
        {
           
            carpmaSayisi++;


            if (carpmaSayisi>=maxCarpmaSayisi)
            {
            toplamTuglaSayisi--;
            
                if (toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
                Destroy(this.gameObject);
            }
            else
            {
                    

                    GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
                }

        

        

        
        }

        
        }
    }


