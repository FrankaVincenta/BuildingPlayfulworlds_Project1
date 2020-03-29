using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour
{
    public GameObject Cam1;

    private void Start()
    {
        StartCoroutine(TheSequence ());

    }

    IEnumerator TheSequence ()
    {
        yield return new WaitForSeconds(2);
    }

}
