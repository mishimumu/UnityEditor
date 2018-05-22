using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attribute__PropertyDrawer : MonoBehaviour
{
    public Ingredient potionResult;
    public Ingredient[] potionIngredients;
}

[System.Serializable]
public class Ingredient
{
    public string name;
    public int amount = 1;
    public IngredientUnit unit;
}



public enum IngredientUnit { Spoon, Cup, Bowl, Piece }
