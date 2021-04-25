using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControlable {
    public bool CanAttack();
    public void Attack();

    public bool CanMove();
}

public class EntityControl<T> where T : IControlable {

    public float speed;
    public T controledEntity;
    public Rigidbody2D entityRigidbody;

    public Animator animator;
    private Vector3 change;

    // Start is called before the first frame update
    void Start() {
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("attack") && controledEntity.CanAttack()) {
            controledEntity.Attack();
        }
    }

    void FixedUpdate() {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (controledEntity.CanMove()) {
            MoveEntity();
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

    void MoveEntity() {
        UpdateAnimation();

        change.Normalize();
        entityRigidbody.MovePosition(entityRigidbody.gameObject.transform.position + change * speed * Time.deltaTime);
    }
}
