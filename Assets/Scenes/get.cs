using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get : MonoBehaviour
{ bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ahh!!!");
    }
    void OnTriggerEnter2D(Collider2D other) 
     {
        if (other.tag == "Obj" )
        {
          Debug.Log("เดิน2ช่อง");
          hasPackage = true;
         
        }
         if (other.tag == "Py"  )
        {
          Debug.Log("เดิน8ช่อง");
          hasPackage = true;
          
        }
         if (other.tag == "Coin3"  )
        {
          Debug.Log("เดิน5ช่อง");
          hasPackage = true;
          
        }
         if (other.tag == "Coin4" )
        {
          Debug.Log("เดิน7ช่อง");
          hasPackage = true;
          
        }
         if (other.tag == "en1" )
        {
          Debug.Log("กลับช่อง23");
          hasPackage = true;
          
        }
         if (other.tag == "en2" )
        {
          Debug.Log("กลับช่อง4");
          hasPackage = true;
          
        }
         if (other.tag == "en3" )
        {
          Debug.Log("กลับช่อง59");
          hasPackage = true;
          
        }
         if (other.tag == "en4" )
        {
          Debug.Log("ถอยหลัง20ช่อง");
          hasPackage = true;
         
        }
         if (other.tag == "en5" )
        {
          Debug.Log("กลับช่อง2");
          hasPackage = true;
          
        }
         if (other.tag == "en6" )
        {
          Debug.Log("กลับช่อง2");
          hasPackage = true;
          
        }
         if (other.tag == "en7" )
        {
          Debug.Log("กลับไปช่องที่1");
          hasPackage = true;
          
        }
        //if (other.tag == "Customer")

        //    Debug.Log("Goooooodd!!");
        //}
     }   
}
