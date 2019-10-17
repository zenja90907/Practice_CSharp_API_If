using UnityEngine;

public class Chicken : MonoBehaviour
{
    Animator animator;
    bool run;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        run = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
            {
                animator.ResetTrigger("吃飯觸發器");
                animator.SetTrigger("吃飯觸發器");
            }
        if (Input.GetKey(KeyCode.R))
        {
            run = true;
        }
        else
        {
            run = false;
        }
        if (run == false)
        {
            animator.SetBool("跑步開關", false);
        }
        if (run == true)
        {
            animator.SetBool("跑步開關", true);
        }
    }
}
