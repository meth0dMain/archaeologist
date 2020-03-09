using UnityEngine;

public class FindObj : MonoBehaviour
{
	Vector3 begin;
	Vector3 offset;
   void OnMouseDown()
   {
	   begin = transform.position;
	   offset = begin - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
   }

   void OnMouseUp()
   {
	   transform.position = begin;
   }

   public void OnMouseDrag()
   {
	   Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1.0f);
	   transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
	}

   void OnTriggerEnter2D(Collider2D other)
   {
	   if (other.transform.name == "Bag")
	   {
		   GetComponentInParent<Square>().ChangeChest();
		   GameObject.Find("Score").gameObject.GetComponent<ScoreCounter>().ChangeScore(100);
		   Destroy(gameObject);
	   }
   }
}
