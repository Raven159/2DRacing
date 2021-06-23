using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItemConfigDataSource", menuName = "UpgradeItemConfigDataSource", order = 0)]
public class UpgradeItemConfigSource : ScriptableObject
{
    public UpgradeItemConfig[] itemConfigs;
}