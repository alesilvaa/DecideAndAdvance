using UnityEngine;

[CreateAssetMenu(fileName = "RuletaData", menuName = "GameData/RuletaData")]
public class RuletaData : ScriptableObject
{
    [System.Serializable]
    public class RuletaSegment
    {
        public Sprite icono;
        public string texto;
        // O cualquier otro dato que quieras mostrar
    }

    public RuletaSegment[] segmentos;
}