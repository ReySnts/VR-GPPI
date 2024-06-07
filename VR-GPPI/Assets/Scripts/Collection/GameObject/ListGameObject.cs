using System.Collections.Generic;
using UnityEngine;

public class ListGameObject : MonoBehaviour, IList<GameObject>
{
    private readonly List<GameObject> list = new();

    public List<GameObject> Collection => list;
}