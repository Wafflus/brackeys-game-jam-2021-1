using UnityEngine;

namespace Artistas
{
	public class Destructible : MonoBehaviour
	{
		[SerializeField] private GameObject[] props;

		[SerializeField] private DestructibleSO destructibleSO;

		[SerializeField] private float currentHP;


		public void Awake()
		{
			currentHP = destructibleSO.maxHP;
		}

		public void Update()
		{
			Heal();
		}

		public void Damage(float damage)
		{
			currentHP -= damage;

			if (currentHP > 0)
			{
				return;
			}

			Destruct();
		}

		private void Destruct()
		{
			destructibleSO.AddReward();

			for (int i = 0; i < props.Length; ++i)
			{
				props[i].SetActive(true);
			}

			Destroy(gameObject);
		}

		private void Heal()
		{
			if (currentHP >= destructibleSO.maxHP)
			{
				return;
			}

			// This could be done differently, but it works.
			currentHP += destructibleSO.healingFactor * Time.deltaTime;
			currentHP = Mathf.Clamp(currentHP, 0f, destructibleSO.maxHP);
		}
	}
}