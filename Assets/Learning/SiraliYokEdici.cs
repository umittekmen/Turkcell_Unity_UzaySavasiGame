using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using Unity.VisualScripting;
public class SiraliYokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrafeb;

    GameObject uzayGemisi;
    List<GameObject> asteroidList;

    GameObject hedefAsteroid;

  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uzayGemisi = GameObject.FindGameObjectWithTag("Player");
        asteroidList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 position = new Vector3(mousePos.x, mousePos.y, 10f);
            position=Camera.main.ScreenToWorldPoint(position);
            GameObject asteroid = Instantiate(asteroidPrafeb, position, Quaternion.identity);
            asteroidList.Add(asteroid);
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            

            HedefiYokEt();



        }
       



    }
    GameObject EnYakinAsteroid()
    {
        GameObject enYakinAsteroid;
        float enYakinMesafe;
        if (asteroidList.Count==0)
        {
            return null;
        }
        else
        {
            enYakinAsteroid = asteroidList[0];
            enYakinMesafe=MesafeOlcer(enYakinAsteroid);

        }
        foreach (GameObject asteroid in asteroidList) 
        {
            float mesafe = MesafeOlcer(asteroid);
            if (mesafe < enYakinMesafe)  
            { 
               enYakinMesafe = mesafe;
                enYakinAsteroid = asteroid; 
            }
        
           
        
        }
        return enYakinAsteroid;
    }



    public void HedefiYokEt()
    {

        hedefAsteroid=EnYakinAsteroid();
        if (hedefAsteroid!=null)
        {
            hedefAsteroid.GetComponent<Yokedici>().AsteroidYokEdici(2);
            asteroidList.Remove(hedefAsteroid);
        }


    }
    float MesafeOlcer(GameObject hedef)
    {
        return Vector3.Distance(uzayGemisi.transform.position, hedef.transform.position);
    }




}
