using UnityEngine;

/*
 * Provide the obstacles with a way of damaging the player.
 */
public class PlayerCollider : MonoBehaviour
{
  public GameObject section;
  private void Update(){
    if(transform.position.x < -15.0f)
      Destroy(gameObject);
    float speed = section.GetComponent<SectionScroller>().speed;
    transform.Translate(new Vector2(-speed, 0) * Time.deltaTime);
  }

  /*
   * A trigger callback to detect when the player's collider has
   * entered the obstacle's. Then simply obtain the PlayerController
   * reference can apply damage. Then remove the obstacle for feedback.
   */
  private void OnTriggerEnter2D(Collider2D other)
  {
    // Obtain a reference to the Player's PlayerController
    PlayerController playerController =
      other.gameObject.GetComponent<PlayerController>();

    // Register damage with player
    playerController.Damage();

    // Make this object disappear
    GameObject.Destroy(gameObject);
  }
}
