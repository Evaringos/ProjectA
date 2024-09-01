using System.Collections;
using UnityEngine;

public class RotateSample : MonoBehaviour
{
	[SerializeField]
	private Vector3 _angle;

	private IEnumerator Start()
	{
		while(true)
		{
			transform.Rotate(_angle * Time.deltaTime);
			yield return null;
		}
	}
}