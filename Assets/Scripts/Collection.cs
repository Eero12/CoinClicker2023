using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{

    public GameObject Collectible1;
    public GameObject Collectible2;
    public GameObject Collectible3;
    public GameObject Collectible4;
    void Update()
    {
        if (BuyCollectibles.BoughtCollectible1)
        {
            Collectible1.SetActive(true);
        }
        if (BuyCollectibles.BoughtCollectible2)
        {
            Collectible2.SetActive(true);
        }
        if (BuyCollectibles.BoughtCollectible3)
        {
            Collectible3.SetActive(true);
        }
        if (BuyCollectibles.BoughtCollectible4)
        {
            Collectible4.SetActive(true);
        }

    }
}
