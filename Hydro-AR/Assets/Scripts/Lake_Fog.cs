using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake_Fog : MonoBehaviour
{
  
    public Animator animator_LF;
    public Animator animator_OF;
    public Animator animator_C1;
    public Animator animator_C2;
    public Animator animator_C3;
    public Animator animator_AS;
    public Animator animator_AE;
    public Animator animator_AC;
    public ParticleSystem particle;

    public Animation anim;
    
    int count = 0;
    bool arrow = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        
        
    }
    
    // Update is called once per frame
    void Update()
    {
        animator_AS.SetTrigger("Arrow_Sun");
        animator_AE.SetTrigger("Arrow_Evaporation");

        //while (arrow)
        //{
        //    animator_AS.SetTrigger("Arrow_Sun");
        //    if (animator_AS.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !animator_AS.IsInTransition(0))
        //    {
        //        animator_AE.SetTrigger("Arrow_Evaporation");
        //        //arrow = false;
        //    }
        //    arrow = false;

        //}


        if (Input.GetKeyDown(KeyCode.Q))
            {
                count++;
                if (count == 1)
                {
                    animator_LF.SetTrigger("Tap_Lake_Fog");
                    animator_OF.SetTrigger("Tap_Ocean_Fog");
                    
                }

                if(count == 2)
                {
                    animator_C1.SetTrigger("Cloud 1_Formation");
                    animator_C2.SetTrigger("Cloud 2_Formation");
                    animator_C3.SetTrigger("Cloud 3_Formation");
                }

                if(count == 3)
                {
                    animator_C1.SetTrigger("Cloud 1_Movement");
                    animator_C2.SetTrigger("Cloud 2_Movement");
                    animator_C3.SetTrigger("Cloud 3_Movement");
                }

                if(count == 4)
                {
                    
                    particle.Play();


                }
            }
    }
}
