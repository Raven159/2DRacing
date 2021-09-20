using UnityEngine;

namespace Company.Project.Features.Abilities
{
    [CreateAssetMenu(fileName = "Ability", menuName = "Ability")]
    public class AbilityItemConfig : ScriptableObject
    {
        public ItemConfig itemConfig;
        public GameObject view;
        public AbilityType type;
        public float value;
        public int Id => itemConfig.id;
    }

    public enum AbilityType
    {
        None,
        Gun,
    }
}