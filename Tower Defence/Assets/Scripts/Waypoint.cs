using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private Tower _ballistaPrefab;
    [SerializeField] private bool _isPlaceable;

    public bool IsPlaceable => _isPlaceable;

    private void OnMouseDown()
    {
        if (_isPlaceable)
        {
            bool isPlaced = _ballistaPrefab.CreateTower(_ballistaPrefab, transform.position);
            _isPlaceable = !isPlaced;
        }
    }
}
