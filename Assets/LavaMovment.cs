using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovment : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Material mat;
    private void Update()
    {
        // Malzeme offsetini güncelle
        var offset = Time.time * speed;
        mat.mainTextureOffset = new Vector2(offset, 0);
    }
}
