/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified:
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
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

    public void playCackle() {
      asc.PlayOneShot(ac);
    }





}
