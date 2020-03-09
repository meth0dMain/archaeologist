using UnityEngine;

public class Square : MonoBehaviour
{
	public GameObject chest;
	int level;
	bool isChest;
	public Sprite[] textures;
	bool clickable = true;

	public void ChangeChest()
	{
		isChest = !isChest;
		clickable = !clickable;
	}
	void OnMouseDown()
	{
		int shovels = GameObject.Find("Shovels").gameObject.GetComponent<ShovelCounter>().shovels_count;
		if (shovels == 0)
			return;
		if (level == 4 && clickable && shovels!= 0)
		{
			GameObject.Find("Score").gameObject.GetComponent<ScoreCounter>().ChangeScore(-400);
			clickable = false;
			GameObject.Find("Shovels").gameObject.GetComponent<ShovelCounter>().ChangeShovels();
			return;
		}
		if (shovels != 0)
		{
			if (clickable)
			{
				isChest = Random.value < 0.25;
				level++;
				GameObject.Find("Shovels").gameObject.GetComponent<ShovelCounter>().ChangeShovels();
				GetComponent<SpriteRenderer>().sprite = textures[level];
			}
			if (isChest)
			{
				clickable = false;
				Instantiate(chest, transform.position, Quaternion.identity, transform);
			}
		}
	}
}

