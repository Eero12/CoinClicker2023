using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalClick : MonoBehaviour
{
    public GameObject PopUp;
    public Animator Animation;

    public void Play()
    {
        Animation.Play("CriticalClickEffect");
        Destroy(gameObject, 0.5f);
    }
}
