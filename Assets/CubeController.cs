using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

	}

    // 接触したときの判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        // キューブが地面かキューブに接触したとき
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "CubePrefab")
        {
            // キューブの効果音を鳴らす
            GetComponent<AudioSource>().Play();
        }
    }

}
