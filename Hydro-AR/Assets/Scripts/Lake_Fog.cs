using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake_Fog : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    private ParticleSystem particle;
   
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        animator = GetComponent<Animator>();
        particle = GetComponent<ParticleSystem>();
        

    }
    

    // Update is called once per frame
    void Update()
    {
        if(animator != null)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                count++;
                if (count == 1)
                {
                    animator.SetTrigger("Tap_lake_Fog");
                    animator.SetTrigger("Tap_Ocean_Fog");
                }

                if(count == 2)
                {
                    animator.SetTrigger("Cloud 1_Formation");
                    animator.SetTrigger("Cloud 2_Formation");
                    animator.SetTrigger("Cloud 3_Formation");
                }

                if(count == 3)
                {
                    animator.SetTrigger("Cloud 1_Movement");
                    animator.SetTrigger("Cloud 2_Movement");
                    animator.SetTrigger("Cloud 3_Movement");
                }

                if(count == 4)
                {
                    var emission = particle.emission;
                    emission.enabled = true;
                    particle.Play();
                }
            }
        }
    }
}
