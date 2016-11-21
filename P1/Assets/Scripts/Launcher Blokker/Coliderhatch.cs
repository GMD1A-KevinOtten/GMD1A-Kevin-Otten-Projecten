using UnityEngine;
using System.Collections;

public class Coliderhatch : MonoBehaviour
{
    //wou ik gebruiken om de Hatch die de launcher blocked zodat de bal niet terug kon gaan te laaten werken.
    public bool hatchclosed;
    public GameObject hatch;

    void Start()
    {
        hatchclosed = false;
        hatch.SetActive(false);
    }


    void OnTriggerEnter()
    {
        hatchclosed = true;
        hatch.SetActive(true);
    }
}
