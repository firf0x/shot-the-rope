using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHitRope : MonoBehaviour
{
    public GameObject[] _rope; //Массив найденых верёвок
    public Material Red; //материал который будет нужен для проверки
    public Material Blue; //материал который будет нужен для проверки
    public Material Green; //материал который будет нужен для проверки
    public Material colors; //материал который будет нужен для проверки
    public Material colorsa; //материал который будет нужен для проверки
    public Material colorsas; //материал который будет нужен для проверки

    public GameObject arrow; // Ссылка на скрипт
    public Arrow scriptArrow; // Ссылка на скрипт
    public Rope rope; // Тоже ссылка на скрипт

    private Transform Position; // Позиция на которую должна отправится стрела
    public GameObject colorRope; // Объект который должен быть удалён при задевании верёвки

    private void Start() {
        _rope = GameObject.FindGameObjectsWithTag("Rope");
        arrow = GameObject.FindWithTag("Arrow");
        scriptArrow = arrow.GetComponent<Arrow>();
    }

    public void CheckColor()
    {
        _rope = GameObject.FindGameObjectsWithTag("Rope");

        for(int index = 0; index < _rope.Length; index++)
        {
            if(_rope[index].GetComponent<Renderer>().material.color == Red.color || _rope[index].GetComponent<Renderer>().material.color == Blue.color || _rope[index].GetComponent<Renderer>().material.color == Green.color || _rope[index].GetComponent<Renderer>().material.color == colors.color || _rope[index].GetComponent<Renderer>().material.color == colorsa.color || _rope[index].GetComponent<Renderer>().material.color == colorsas.color)
            {
                Debug.Log("цвет найден");
                colorRope = _rope[index];
                Position = _rope[index].transform.Find("tp");
                scriptArrow.targetPoint = Position;
            }
            else
            {
                Debug.Log("такого цвета нет");
            }
        }
    }
}