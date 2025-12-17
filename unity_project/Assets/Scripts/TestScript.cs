using TMPro;
using UnityEngine;

public class TestScript : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI numTMP; 

	private int num = 0;

	private void Update()
	{
		numTMP.text = $"{num}"; 
	}

	public void ChangeNum(int passed)
	{
		num += passed; 
	}
}
