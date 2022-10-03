using UnityEngine;

namespace PluginB
{
    public class Character : MonoBehaviour
    {
        [SerializeField]private string name = "Kevin";
        [SerializeField] private int maxHealth = 100;

        private void Start()
        {
            Debug.Log($"Game starts for {name}. Healh = {maxHealth}");
        }
    }
}
