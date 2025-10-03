using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CactusAnimator : MonoBehaviour
{
    // Start is called before the first frame update

    public float radius = 50f;
    public string animatorBool = "isAttacking";
    public Transform otherCactus;
    private Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (otherCactus == null || animator == null) return;
        float dist = Vector3.Distance(transform.position, otherCactus.position);

        if (dist <= radius)
            animator.SetBool(animatorBool, true);
        else
            animator.SetBool(animatorBool, false);
    }
}
