using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState {
    idle,
    walk,
    attack,
    interact,
    stagger
}

public class PlayerControl : MonoBehaviour {

    public PlayerState currentState;
    public float speed;

    private Rigidbody2D myRigidbody;
    private Vector3 change;

    // Start is called before the first frame update
    void Start() {
        currentState = PlayerState.idle;

        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate() {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (CanMove()) {
            MoveEntity();
        }
    }

    void MoveEntity() {
        change.Normalize();
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

    public void Knock(float knockTime) {
        StartCoroutine(KnockCoroutine(knockTime));
    }

    private IEnumerator KnockCoroutine(float knockTime) {
        if (myRigidbody != null) {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = PlayerState.idle;
        }
    }

    public bool CanAttack() {
        return (currentState != PlayerState.attack && currentState != PlayerState.stagger);
    }

    public bool CanMove() {
        return (currentState == PlayerState.idle || currentState == PlayerState.walk);
    }

    public void Attack() {
        StartCoroutine(AttackCoroutine());
    }

    private IEnumerator AttackCoroutine() {
        //animator.SetBool("attacking", true);
        //currentState = PlayerState.attack;
        //yield return null;
        //animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);
        currentState = PlayerState.walk;
    }


}
