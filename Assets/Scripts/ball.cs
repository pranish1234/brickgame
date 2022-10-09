using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool inplay;
    public Transform player;
    [SerializeField]private float ballSpeed;
    public GameManager gameManager;
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
            gameManager.updatelives(-1);
        } 
   }
   private void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.CompareTag("brick"))
        {   
            Destroy(other.gameObject);
            gameManager.updatescore(1);
        }
   }
    private void Jump(){
        inplay = true;
        rb.AddForce(Vector2.up*ballSpeed);
    }
}
