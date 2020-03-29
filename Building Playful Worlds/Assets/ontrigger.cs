using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ontrigger : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer ren;
    public GameObject player;
    public int col;
    void Start()
    {
        ren = GetComponent<Renderer>();
        col = 1;
        if (col == 1)
        {
            ren.material.color = Color.red;
            col = col + 1;
        }
        else if (col == 2)
        {
            ren.material.color = Color.blue;
            col = col + 1;
        }
        else if (col == 3)
        {
            ren.material.color = Color.green;
            col = col + 1;
        }
        else if (col == 4)
        {
            ren.material.color = Color.yellow;
            col = col + 1;
        }
        else if (col == 5)
        {
            ren.material.color = Color.white;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("reee");
        if (other.gameObject == player) {
            Debug.Log(col);
            if (col == 1)
            {
                ren.material.SetColor("_BaseColor", Color.red);
                col = col + 1;
            }
            else if (col == 2)
            {
                ren.material.SetColor("_BaseColor", Color.blue);
                col = col + 1;
            }
            else if (col == 3)
            {
                ren.material.SetColor("_BaseColor", Color.green);
                col = col + 1;
            }
            else if (col == 4)
            {
                ren.material.SetColor("_BaseColor", Color.black);
                col = col + 1;
            }
            else if (col == 5)
            {
                ren.material.SetColor("_BaseColor", Color.white);
                col = 1;
                SceneManager.LoadScene("EndMenu");
            }
        }
    }
}
