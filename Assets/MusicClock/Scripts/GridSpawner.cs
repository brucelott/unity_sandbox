using UnityEngine;
using System.Collections;

// instantiates an n by n grid of the prefab
public class GridSpawner : MonoBehaviour {

	[SerializeField] Vector3 positionOffset;
	[SerializeField] int numberOfRows, numberOfColumns;
	[SerializeField] float spaceBetweenElements;
	[SerializeField] GameObject prefab = null;

	void Start() {
		for(int x = 0; x < numberOfRows; x++) {
			for (int z = 0; z < numberOfColumns; z++) {
				Vector3 position = Vector3.zero;
				position.x = x * spaceBetweenElements + positionOffset.x;
				position.y = positionOffset.y;
				position.z = z * spaceBetweenElements + positionOffset.z;
				GameObject copy = Instantiate(prefab, 
					position, Quaternion.identity) as GameObject;
				copy.transform.parent = this.transform;
			}
		}
		// Vector3 newPosition = this.transform.position;
		// newPosition.x = -1.5f;
		// newPosition.y = 2.4f;
		// newPosition.z = -1.5f;
		// this.transform.position = positionOffset;
	}

}
