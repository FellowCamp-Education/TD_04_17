using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class ClickControl : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject TowerPrefab;

    int enemyPathMask = 1 << 3;
    int towerMask = 1 << 4;

    public void OnPointerClick(PointerEventData eventData)
    {
        NavMeshHit hit;
        NavMesh.SamplePosition(eventData.pointerCurrentRaycast.worldPosition, out hit, 0.1f, NavMesh.AllAreas);
        if (hit.mask == towerMask && eventData.button == PointerEventData.InputButton.Left)
        {
            Instantiate(TowerPrefab, hit.position, Quaternion.identity);
        }
    }
}
