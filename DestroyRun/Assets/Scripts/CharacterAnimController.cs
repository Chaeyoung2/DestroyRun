using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimController : MonoBehaviour
{
    public Animation anim;
    public GameObject player;
    public TestCharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        anim.CrossFade("Idle");
        player = GameObject.Find("Player");
        charController = player.GetComponent<TestCharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (charController.jump == true)
        {
            anim.CrossFade("Jump_Loop");
        }
        else if(charController.run == true)
        {
            anim.CrossFade("Run");
        }
        else if (charController.dash == true)
        {
            anim.CrossFade("Dash");
        }
        else
        {
            anim.CrossFade("Idle");
        }
        //anim.CrossFade("Idle");
        //anim.CrossFade("Jump_Open");
        //anim.CrossFade("Jump_Loop");
        //anim.CrossFade("Jump_End");
        //anim.CrossFade("Slam");
        //anim.CrossFade("Dash");
        //anim.CrossFade("Knock_Down");
        //anim.CrossFade("Knock_Down_Loop");
        //anim.CrossFade("Knock_Down_Up");
        //anim.CrossFade("Ulti_Open");
        //anim.CrossFade("Ulti_Loop");
        //anim.CrossFade("Ulti_End");
    }
}
