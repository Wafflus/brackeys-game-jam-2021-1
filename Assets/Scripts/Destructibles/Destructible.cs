using UnityEngine;

namespace Artistas
{
	public class Destructible : MonoBehaviour
	{
		[SerializeField] private GameObject[] props;

		[SerializeField] private float maxHP = 100f;
		[SerializeField] private float currentHP = 100f;
		[SerializeField] private float healingFactor = 10f;

		[SerializeField] private CurrencySO currency;
		[SerializeField] private int reward = 200;

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
			currency.Add(reward);

			for (int i = 0; i < props.Length; ++i)
			{
				props[i].SetActive(true);
			}

			Destroy(gameObject);
		}

		private void Heal()
		{
			if (currentHP >= maxHP)
			{
				return;
			}

			// This could be done differently, but it works.
			currentHP += healingFactor * Time.deltaTime;
			currentHP = Mathf.Clamp(currentHP, 0f, maxHP);
		}
	}
}