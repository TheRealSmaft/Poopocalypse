using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopScooper : MonoBehaviour {

    [SerializeField]
    private ScoreKeeper scoreKeeper;
    private List<Poop> poopList = new List<Poop>();

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && poopList.Count > 0)
        {
            ScoopPoop(poopList[0]);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Poop")
        {
            Poop poop = other.GetComponent<Poop>();
            if(!poop.isSquished && !poopList.Contains(poop))
            {
                poopList.Add(poop);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Poop")
        {
            Poop poop = other.gameObject.GetComponent<Poop>();
            if (!poop.isSquished && poopList.Contains(poop))
            {
                poopList.Remove(poop);
            }
        }
    }

    public void RemovePoopFromPoopList(Poop poop)
    {
        if(poopList.Contains(poop))
        {
            poopList.Remove(poop);
        }
    }

    private void ScoopPoop(Poop poop)
    {
        poopList.Remove(poop);
        GameObject.Destroy(poop.gameObject);
        scoreKeeper.AddValue();
    }
}
