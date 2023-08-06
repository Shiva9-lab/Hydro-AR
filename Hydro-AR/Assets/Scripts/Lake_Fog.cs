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
    public ParticleSystem particle;
    
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        animator_LF = GetComponent<Animator>();
        animator_OF = GetComponent<Animator>();
        animator_C1 = GetComponent<Animator>();
        animator_C2 = GetComponent<Animator>();
        animator_C3 = GetComponent<Animator>();
        particle = GetComponentInChildren<ParticleSystem>();
        //particle.SetActive(false);
        
    }
    

    // Update is called once per frame
    void Update()
    {
         
        
            //animator.Play("Base Layer.Arrow_Sun");
            if (Input.GetKeyDown(KeyCode.Q))
            {
                count++;
                if (count == 1)
                {
                    animator_LF.SetTrigger("Tap_lake_Fog");
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
