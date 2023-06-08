using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonRotation : MonoBehaviour
{
    public Transform cannonTransform;
    public Slider AngleSlider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = cannonTransform.rotation;
        RotateCannon();
    }
    private void RotateCannon()
    {
        float angle = AngleSlider.value * 60;
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle-45);
        transform.rotation = targetRotation;
    }
}
