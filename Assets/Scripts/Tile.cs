using UnityEngine;
using System.Collections;

public enum TILE_TYPES {
    WALL = 0,
    CORRIDOR,
    GOAL,
    SPAWN,

    COUNT
}

public class Tile {
    #region Members
    private Vector2 m_Position;
    private TILE_TYPES m_Type;
    public TILE_TYPES p_Type {
        get {
            return m_Type;
        }
        set {
            int valueToInt = (int)value;
            if (valueToInt < 0
                || valueToInt > (int)TILE_TYPES.COUNT) {
                m_Type = TILE_TYPES.WALL;
            }
            else {
                m_Type = value;
            }
        }
    }
    #endregion

    #region Constructors
    public Tile (float x, float y) {
        m_Position = new Vector2 (x, y);
    }

    public Tile ()
        : this (0.0f, 0.0f) { }
    #endregion

    public Vector2 GetPosition () {
        return m_Position;
    }

    public void SetPosition (float x, float y) {
        m_Position.x = x;
        m_Position.y = y;
    }
}
