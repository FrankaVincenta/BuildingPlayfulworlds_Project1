using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

     void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());

    }


    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(10); // hoeveel secondden de cutscene duurt
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
