using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{
    public GameObject targetObject; // The object to disable
    public float delay = 2f;        // Time in seconds before disabling

    private void Start()
    {
        StartCoroutine(DisableObject());
    }

    private System.Collections.IEnumerator DisableObject()
    {
        yield return new WaitForSeconds(delay);
        targetObject.SetActive(false);
    }
}
