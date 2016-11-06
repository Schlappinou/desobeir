using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {


    Animator animator;

    // Use this for initialization
    void Start()
    {
        // find one time for all the animator attached to this gameobject + Debug
        animator = GetComponent<Animator>(); 
        if(animator == null)
        {
            Debug.Log("Animator is null for "+transform.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // here value of some imput
        //< float | bool |...> -value to be set- = Input.GetAxis(String name of Imput);
        float f  = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        bool b = PlayerController.instance.IsAttaque;

        if (animator != null)
        {
            //here set of value of animator parameters 
            //animator.SetFloat(string parameter name, <float|bool|...> value to be set);
            animator.SetFloat("forward", v);
            animator.SetFloat("left", f);
            animator.SetBool("attaque", b);
        }

    }
}
