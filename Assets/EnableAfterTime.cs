using UnityEngine;

public class EnableAfterTime : MonoBehaviour
{
    public GameObject targetObject; // The object to enable
    public float delay = 2f;        // Time in seconds before enabling

    private void Start()
    {
        // Start a coroutine that waits then enables the object
        StartCoroutine(EnableObject());
    }

    private System.Collections.IEnumerator EnableObject()
    {
        yield return new WaitForSeconds(delay);
        targetObject.SetActive(true);
    }
}
