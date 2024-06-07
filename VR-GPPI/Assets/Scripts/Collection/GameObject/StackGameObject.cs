using System.Collections.Generic;
using UnityEngine;

public class StackGameObject : MonoBehaviour, IStack<GameObject>
{
    private readonly Stack<GameObject> stack = new();

    public Stack<GameObject> Collection => stack;
}