using System.Collections;
using UnityEngine;

public class SpawnSnow : MonoBehaviour {
    public GameObject snow;

    void Start () {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
        while (true) {
            Instantiate(snow, new Vector2(Random.Range(-10.2f, 10.2f), 5.6f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
	
}
