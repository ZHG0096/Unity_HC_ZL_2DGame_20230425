using UnityEngine;

public class DamageBasic : MonoBehaviour
{
	[Header("���")]
	public DataBasic data;
	private float hp;
	private void Awake()
	{
		hp = data.hp;
	}
	public void Damage(float damage)
	{
		hp -= damage;

		print($"<color=#ffee66>{gameObject.name} ��q�ѤU:{hp}</color>");
		if (hp <= 0) Dead();
	}
	private void Dead()
	{
		print($"<color=#ffee66>{gameObject.name} ���`:</color>");
	}
}
