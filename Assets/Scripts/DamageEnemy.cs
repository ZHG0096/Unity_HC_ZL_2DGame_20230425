
using UnityEngine;

public class DamageEnemy : DamageBasic
{
	public GameObject prefabsDamage;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name.Contains("ชZพน"))
			Instantiate(prefabsDamage, transform.position, transform.rotation);
			Damage(50);
	}
}
