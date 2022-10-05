using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private float rightCorner;
    [SerializeField]private float leftCorner;
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right*Horizontal*Time.deltaTime*speed);

            if (transform.position.x<leftCorner)
            {
                transform.position = new Vector2(leftCorner,transform.position.y);
            }
            
            if (transform.position.x>rightCorner)
            {
                transform.position = new Vector2(rightCorner,transform.position.y);    
            }
        
    }
}
