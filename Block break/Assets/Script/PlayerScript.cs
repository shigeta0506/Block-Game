using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{ 
    public float speed = 20f;

    Rigidbody rigidbody;

    [SerializeField] private GameObject Point;
    [SerializeField] private GameObject Ball;
    public int count = 0;
    //[SerializeField]
    //private float bounce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.Space) && count == 0)
        {
            // 弾を発射する場所を取得
            Vector3 bulletPosition = Point.transform.position;
            // 上で取得した場所に、"bullet"のPrefabを出現させる。Bulletの向きはMuzzleのローカル値と同じにする（3つ目の引数）
            GameObject newBullet = Instantiate(Ball, bulletPosition, this.gameObject.transform.rotation);
            // 出現させた弾のup(Y軸方向)を取得（MuzzleのローカルY軸方向のこと）
            Vector3 direction = newBullet.transform.up;
            // 弾の発射方向にnewBallのY方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
            newBullet.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);

            count++;
        }

    }
}