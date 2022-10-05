using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool inplay;
    public Transform player;
    [SerializeField]private float ballSpeed;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

        private void Update() {
            if(!inplay){
            transform.position = new Vector2(player.position.x,player.position.y);
            }
            if (Input.GetButtonDown("Jump") && !inplay)
            {
                Jump();
            }
        }

   private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("deathcollider"))
        {
            inplay = false;
            rb.velocity = Vector2.zero;
        } 
   }
   private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.CompareTag("brick"))
        {
            Destroy(other.gameObject);
        }
   }
    private void Jump(){
        inplay = true;
        rb.AddForce(Vector2.up*ballSpeed);
    }
}
