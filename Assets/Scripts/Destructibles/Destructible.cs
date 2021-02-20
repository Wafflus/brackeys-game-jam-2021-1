using UnityEngine;

namespace Artistas
{
	public class Destructible : MonoBehaviour
	{
		[SerializeField] private GameObject[] props;

		[SerializeField] private DestructibleSO destructibleSO;

		[SerializeField] private float currentHP;

		private Material hpMaterial;

		public void Awake()
		{
			currentHP = destructibleSO.maxHP;
			hpMaterial = GetComponent<Renderer>().material;
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
			UpdateMaterialHP();
		}

		private void Destruct()
		{
			destructibleSO.AddReward();

			for (int i = 0; i < props.Length; ++i)
			{
				props[i].SetActive(true);
			}

			destructibleSO.OnDestructibleDestruction.Raise();

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
			UpdateMaterialHP();
		}

		private void UpdateMaterialHP()
		{
			hpMaterial.SetFloat("_HP", currentHP / destructibleSO.maxHP);
		}
	}
}