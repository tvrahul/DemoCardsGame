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
        Invoke("MiddleCardsAnim", 1.8f);

    }

    void ChangeCard()
    {
        if (isMiddleShowing == false)
        {
            int n = Random.Range(0, materials.Length);
            GetComponent<MeshRenderer>().material = materials[n];

            //Instantiate(objectsToInstantiate[n], pos.position, objectsToInstantiate[n].transform.rotation);
        }
        isMiddleShowing = true;

    }

    void MiddleCardsAnim()
    {

        middleCards.GetComponent<Animator>().Play("MiddleCards");

    }
}
