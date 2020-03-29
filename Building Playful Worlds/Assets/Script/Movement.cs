using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{    // Public zorgt ervoor dat iedereen het kan benaderen
    Rigidbody player; // player is een riggidbody

    public int VolgendeKleuCycle; // welke kleur moet hij uitvoeren in mijn if-statements
    public GameObject cillinder; // Definitie van een object. Public zodat we dit aan de cillinder kunnen verbinden zonder nieuw script te maken.

    public float gravity = -9.81f;
    Vector3 velocity;
    bool isGrounder;

    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;

    public CharacterController controller;

    public float speed = 12f;
    public float jumpHeight = 2f;


    // je zet iets op public zodat je het in Unity zelf kan aanpassen en andere classen benadreren
    void Start()
    {
       player = GetComponent<Rigidbody>(); // rigibody vast stellen welke het is. 

        VolgendeKleuCycle = 1; // startwaarde verbinden

    }
    // Update is called once per frame
    void Update()
    {
        isGrounder = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounder && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounder == true)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.gameObject == cillinder)
        {
            var CilinderMaterial = cillinder.GetComponent<Renderer>(); // Pak de rendererer uit de cillinder. 

           if  (VolgendeKleuCycle == 1)
            {
                CilinderMaterial.material.SetColor("_Color", Color.black);
                VolgendeKleuCycle = 2; // ga naar volgende cycle 
            } else if (VolgendeKleuCycle == 2)
            {
                CilinderMaterial.material.SetColor("_Color", Color.yellow);
                VolgendeKleuCycle = 3;
            } else if (VolgendeKleuCycle == 3)
            {
                CilinderMaterial.material.SetColor("_Color", Color.cyan);
                VolgendeKleuCycle = 1;
            }


        }
    }

}

