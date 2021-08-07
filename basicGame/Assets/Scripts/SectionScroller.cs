using UnityEngine;

/*
 * Attached to the section so that everything will scroll sideways.
 * The player does not move in this game, the environment does.
 */
public class SectionScroller : MonoBehaviour
{
  public GameObject barrel;
  public Transform player;
  public float speed = 10.0f;
  private float far = 10.0f;
  private float limit = 100.0f;
  /*
   * Use the Transform component attached to the section game object and
   * translate it based on delta time.
   */
  private void Update()
  {
    if(limit - far > 25.0f){
      float put = Random.value * 13.0f + 12.0f;
      int choose = Random.Range(1,6);
      if(put<16.0f) choose = 1;

      switch(choose){
        case 2:
          Instantiate(barrel,(player.position.x+ far + put) * transform.right - 3 * transform.up,Quaternion.identity);
          Instantiate(barrel,(player.position.x+ far + put - 3.0f) * transform.right + 3 * transform.up,Quaternion.identity);
          break;
        case 3:
          Instantiate(barrel,(player.position.x+ far + put) * transform.right - 3 * transform.up,Quaternion.identity);
          Instantiate(barrel,(player.position.x+ far + put + 1.0f) * transform.right - 3 * transform.up,Quaternion.identity);
          break;
        case 4:
          Instantiate(barrel,(player.position.x+ far + put) * transform.right - 3 * transform.up,Quaternion.identity);
          Instantiate(barrel,(player.position.x+ far + put + 4.0f) * transform.right + 3 * transform.up,Quaternion.identity);
          break;

        default:
          Instantiate(barrel,(player.position.x+ far + put) * transform.right - 3 * transform.up,Quaternion.identity);break;
      }
      far += put;
    }
    far -= speed * Time.deltaTime;
  }
}
