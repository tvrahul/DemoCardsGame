using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerCards : MonoBehaviour
{
    public Material[] materials;

    [SerializeField] GameObject cardAnim01;
    [SerializeField] GameObject cardAnim02;

    [SerializeField] SimpleCards simpleCards;

    [SerializeField] bool isLowerShowing = false;
    // Start is called before the first frame update
    void Start()
    {
        simpleCards.GetComponent<SimpleCards>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
            StartCoroutine(simpleCards.SimpleCardSpawne());
            Invoke("ChangeCard", 1.3f);
        
    }

    void ChangeCard()
    {
          if (isLowerShowing == false)

          {
                int n = Random.Range(0, materials.Length);
                GetComponent<MeshRenderer>().material = materials[n];
                cardAnim01.GetComponent<Animator>().Play("LowerCard01");
                cardAnim02.GetComponent<Animator>().Play("LowerCard02");

                //Instantiate(objectsToInstantiate[n], pos.position, objectsToInstantiate[n].transform.rotation);
          }

            isLowerShowing = true;
        }

    
}
