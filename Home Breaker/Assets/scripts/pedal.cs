using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedal : MonoBehaviour
{

    [SerializeField] float ekranGenisligiUnitCinsinden = 14f;
    private float xMin = 1f, xMax = 15f;

    void Start()
    {

    }

    void Update()
    {
        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        farePozUnitCinsinden = Mathf.Clamp(farePozUnitCinsinden, xMin, xMax);
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        transform.position = pedalPozisyonu;
    }

}
