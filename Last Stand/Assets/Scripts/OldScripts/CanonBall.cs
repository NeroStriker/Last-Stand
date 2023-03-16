using UnityEngine;

public class CanonBall : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float damage;
    public float BulletTime = 3;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        BulletTime += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= direction* (speed *Time.deltaTime);
        CountDown();
        
    }

    private void CountDown()
    {
        if(BulletTime <= Time.time)
        {
            Destroy(bullet);
        }
    }

    private void Bigger()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2;
        }
    }

}
