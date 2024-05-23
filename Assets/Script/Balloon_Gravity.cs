using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Gravity : MonoBehaviour
{
    private Rigidbody rb;
    public float yerCekimiKatsayisi = 1f;
    public static bool _gravity = true;
    private void Start()
    {
        // Rigidbody bile�enini al
        rb = GetComponent<Rigidbody>();
        // Yer �ekimini kapat
        rb.useGravity = false;
    }

    private void FixedUpdate()
    {
        if (_gravity)
        {
            Vector3 yerCekimi = yerCekimiKatsayisi * Physics.gravity;
            rb.AddForce(yerCekimi, ForceMode.Force);
        }
        // Yer �ekimini uygula
        
    }


}
