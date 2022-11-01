using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howl : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource asc;
    AudioClip ac;



    private void Start()
    {
        anim = GetComponent<Animator>();
        asc = GetComponent<AudioSource>();
        ac = asc.clip;

    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            anim.SetBool(animtionParamater, true);
        }
    }

    private void OnTriggerExit(Collider other)
        {
          if(other.tag == "Player")
            {
                anim.SetBool(animtionParamater, false);
            }
        }

    public void playaudio() {
      asc.PlayOneShot(ac);
    }
  }
