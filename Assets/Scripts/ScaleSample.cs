using System.Collections;
using UnityEngine;

public class ScaleSample : MonoBehaviour
{
	[SerializeField]
	private Vector3 _min = new Vector3(0.1f, 0.1f, 0.1f);

	[SerializeField]
	private Vector3 _max = Vector3.one;

	[SerializeField]
	private float _timeToScale = 5f;

	[SerializeField]
	private float _delay;

	private IEnumerator Start()
	{
		while (true)
		{
			yield return ToScale(_max, _min);
			yield return ToScale(_min, _max);
		}
	}

	private IEnumerator ToScale(Vector3 start, Vector3 end)
	{
		var time = 0f;
		while (_timeToScale > time)
		{
			transform.localScale = Vector3.Lerp(start, end, 1f - (_timeToScale - time) / _timeToScale);
			time += Time.fixedDeltaTime;
			yield return new WaitForFixedUpdate();
		}
		yield return new WaitForSeconds(_delay);
	}

	[ContextMenu("Set Max")]
	private void SetMax()
	{
		transform.localScale = _max;
	}
	
	[ContextMenu("Set Min")]
	private void SetMin()
	{
		transform.localScale = _min;
	}
}