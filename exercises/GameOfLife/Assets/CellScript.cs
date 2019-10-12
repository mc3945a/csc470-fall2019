using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
	public bool alive = false;
	public bool nextAlive;
	bool prevAlive;
	public int x = -1;
	public int y = -1;
    public float aliveySize = 1.2f;

	Renderer renderer;
    Vector3 originScale; 


	// Start is called before the first frame update
	void Start()
    {
		prevAlive = alive;
        originScale = this.transform.localScale; // grab original scale of object
    }

    // Update is called once per frame
    void Update()
    {
		if (prevAlive != alive) {
			updateColor();
		}


		prevAlive = alive;
	}

	public void updateColor()
	{
		if (renderer == null) {
			renderer = gameObject.GetComponent<Renderer>();
		}

		if (this.alive) {
			renderer.material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			// set scale equal to new vector 3 with new Y size 
			this.transform.localScale = new Vector3(originScale.x, originScale.y * aliveySize, originScale.z);
		} else {
			renderer.material.color = Color.white;
			// set scale back to origin
			this.transform.localScale = originScale;
        }
	}

	private void OnMouseDown()
	{
		alive = !alive;

	}
}
