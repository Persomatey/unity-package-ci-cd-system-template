using TMPro;
using UnityEngine;

namespace unity_packages_cd_cd_system_template
{
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

		public void QuitGame()
		{
			Application.Quit();
		}
	}
}
