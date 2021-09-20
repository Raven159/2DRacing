using Company.Project.Features.Abilities;
using UnityEngine;

namespace Company.Project.ContentData
{
    [CreateAssetMenu(fileName = "AbilityItemConfigDataSource", menuName = "AbilityItemConfigDataSource", order = 0)]
    internal class AbilityItemConfigDataSource : ScriptableObject
    {
        public AbilityItemConfig[] itemConfig;
    }
}