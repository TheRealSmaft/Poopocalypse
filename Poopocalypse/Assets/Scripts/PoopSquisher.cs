using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSquisher : MonoBehaviour {

    [SerializeField]
    private PoopScooper poopScooper;
    [SerializeField]
    private ScoreKeeper scoreKeeper;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Poop")
        {
            Poop poop = other.GetComponent<Poop>();
            if (!poop.isSquished)
            {
                poop.Squish();
                poopScooper.RemovePoopFromPoopList(poop);
                scoreKeeper.RemoveValue();
            }
        }
    }
}
