using UnityEngine;

[CreateAssetMenu(fileName = "PrefabData")]
public class PrefabData : ScriptableObject
{
	public GameObject Prefab;
	public Sprite SpriteImage;
	public Color SpriteColor;

	public void OnConfigure()
	{
		var newPrefab = Instantiate(Prefab);
	}




}
