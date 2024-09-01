using System.Collections;
using UnityEngine;

public class MoveSample : MonoBehaviour
{
	private Vector3 _min; [SerializeField]
	private Vector3 _max; [SerializeField]
	private float _timeToMove = 0.1f; [SerializeField]
	private float _delay; [SerializeField]

	private IEnumerator Start()
	{
		while (true)
		{
			yield return ToMove(_max, _min);
			yield return ToMove(_min, _max);
		}
	}

	private IEnumerator ToMove(Vector3 start, Vector3 end)
	{
		var time = 0f;
		while (_timeToMove > time)
		{
			transform.localPosition = Vector3.Lerp(start, end, 1f - (_timeToMove - time) / _timeToMove);
			time += Time.deltaTime;
			yield return null;
		}
		yield return new WaitForSeconds(_delay);
	}
}