using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleCards : MonoBehaviour
{

    public Material[] materials;

    [SerializeField] GameObject middleCards;
    [SerializeField] bool isMiddleShowing = false;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeCard();
        
       Invoke ("MiddleCardsAnim", 2f);

    }


  
    
    void ChangeCard()

        {
            if (isMiddleShowing == false)
            {
                int n = Random.Range(0, materials.Length);
                GetComponent<MeshRenderer>().material = materials[n];
                Invoke("ChangeCard", 1f);
                middleCards.GetComponent<Animator>().Play("MiddleCards");


            }
            isMiddleShowing = true;

        }
    void MiddleCardsAnim()
    {
      
        
            middleCards.GetComponent<Animator>().Play("MiddleCards");
            
        

    }



}

    


