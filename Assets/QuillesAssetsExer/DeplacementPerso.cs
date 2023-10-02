using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPerso : MonoBehaviour
{
    public float vitesseDeplacement;
    public float vitesseRotation;

    float vitesse;
    float tourne;
    

    // Update is called once per frame
    void Update()
    {
         vitesse = Input.GetAxis("Vertical") * vitesseDeplacement;
         tourne = Input.GetAxis("Mouse X") * vitesseRotation;

        transform.Rotate(0f, tourne, 0f);
   
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0f, 0f, vitesse);
    }


}
