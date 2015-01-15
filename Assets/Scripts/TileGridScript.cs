using UnityEngine;
using System.Collections;

public class TileGridScript : MonoBehaviour {
    #region Members
    public Tile[][] m_Grid;
    public const int c_GridWidth = 28;
    public const int c_GridHeight = 31;
    #endregion

    protected void Awake () {
        InitializeGrid ();
    }

    protected void Update () {

    }

    protected void InitializeGrid () {
        m_Grid = new Tile[c_GridWidth][];
        for (int i = 0; i < c_GridWidth; ++i) {
            m_Grid[i] = new Tile[c_GridHeight];
        }

        float currentX = -13.5f;
        for (int i = 0; i < c_GridWidth; ++i) {
            float currentY = -15.0f;
            for (int j = 0; j < c_GridHeight; ++j) {
                m_Grid[i][j] = new Tile (currentX, currentY);
                ++currentY;
            }
            ++currentX;
        }


        // -13.5 <-> 13.5   27 (-13.5)
        // 15 <-> -15       30 (-15)
    }

    protected void InitializeGridTypes () {
        // Corridors
        for (int i = 0; i < c_GridWidth; ++i) {
            for (int j = 0; j < c_GridHeight; ++j) {
                Vector2 tilePosition = m_Grid[i][j].GetPosition ();
                if (tilePosition.y == 14.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= -1.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 1.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == 10.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == 7.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= -7.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= -4.5f
                        && tilePosition.x <= -1.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 1.5f
                        && tilePosition.x <= 4.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 7.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == 4.0f) {
                    if (tilePosition.x >= -4.5f
                        && tilePosition.x <= 4.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == 1.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= -4.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 4.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == -2.0f) {
                    if (tilePosition.x >= -4.5f
                        && tilePosition.x <= 4.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == -5.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= -1.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 1.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == -8.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= -10.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= -7.5f
                        && tilePosition.x <= 7.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 10.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == -11.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= -7.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= -4.5f
                        && tilePosition.x <= -1.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 1.5f
                        && tilePosition.x <= 4.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                    else if (tilePosition.x >= 7.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
                else if (tilePosition.y == -14.0f) {
                    if (tilePosition.x >= -12.5f
                        && tilePosition.x <= 12.5f) {
                        m_Grid[i][j].p_Type = TILE_TYPES.CORRIDOR;
                    }
                }
            }
        }

        // Spawns
        for (int i = 0; i < c_GridWidth; ++i) {
            for (int j = 0; j < c_GridHeight; ++j) {
            }
        }

        // Goal
        for (int i = 0; i < c_GridWidth; ++i) {
            for (int j = 0; j < c_GridHeight; ++j) {
            }
        }
    }
}
