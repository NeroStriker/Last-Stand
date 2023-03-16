using UnityEngine;

public class EnemyType : MonoBehaviour
{
    private enum EnemyTypes
    {
        Basic,
        Boss
    }
    [SerializeField]private EnemyTypes enemyType;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        SetEnemyType(enemyType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetEnemyType(EnemyTypes enemyType)
    {
        switch(enemyType)
        {
            case EnemyTypes.Basic:
                color= Color.white;
                break;

            case EnemyTypes.Boss:
                color= Color.red;
                break;
            default:
                color = Color.green;  
                    break;
        }
    }
}
