using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private ParticleSystem effect;

    private void Start()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Damage"))
        {
            Instantiate(effect, gameObject.transform.position, gameObject.transform.rotation);
            effect.GetComponent<ParticleSystem>().Play();

            _anim.Play("BalloonAnimation");
        }
       
    }
    public void Finish()
    {
        gameManager.TheBalloonPopped();
    }

}
