using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControledEntityAnimator : MonoBehaviour {

    public PlayerControl controledEntity;

    private Animator animator;
    private Vector3 change;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
    }

    // Update is called once per frame
    void Update() {
        //if (Input.GetButtonDown("Attack") && CanAttack()) {
        //    Attack();
        //}
    }

    void FixedUpdate() {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (controledEntity.CanMove()) {
            UpdateAnimation();
        }
    }

    void UpdateAnimation() {
        if (change != Vector3.zero) {
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        } else {
            animator.SetBool("moving", false);
        }
    }
}
