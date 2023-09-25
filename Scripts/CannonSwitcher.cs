using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSwitcher : MonoBehaviour
{

    public GameObject Cannon1;
    public GameObject Cannon2;
    public GameObject Cannon3;
    public GameObject Cannon4;
    // Start is called before the first frame update
    void Start()
    {
        Cannon1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           if(Cannon1.activeSelf == true)
            {
                Cannon1.SetActive(false);
                Cannon2.SetActive(true);
            }
           else if (Cannon2.activeSelf == true)
            {
                Cannon2.SetActive(false);
                Cannon3.SetActive(true);
            }

            else if (Cannon3.activeSelf == true)
            {
                Cannon3.SetActive(false);
                Cannon4.SetActive(true);
            }

            else if (Cannon4.activeSelf == true)
            {
                Cannon4.SetActive(false);
                Cannon1.SetActive(true);
            }


        }
    }
}
