using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectorScript : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab = default!;
    [SerializeField] PointTextScript pointText = default!;
    [SerializeField] LvTextScript levelText = default!;
    [SerializeField] LeftTextScript leftText = default!;
    [SerializeField] GameObject gameclear = default!;
    [SerializeField] GameObject gameover = default!;
    [SerializeField] GameObject titleButton = default!;
    [SerializeField] PlayerScript player = default!;
    [SerializeField] GameObject[] blockParent = default!;
    [SerializeField] float fulletForce = 20f;// 弾の発射力
    int point = 0;// 得点
    int level = 1;// レベル
    [SerializeField] int left = 2;// 残機
    int leftBlock;// 残りブロック数
    GameObject ball = null;

    public const int LEVEL_MAX = 3;

    // Start is called before the first frame update
    void Start()
    {
        pointText.SetPoint(point);
        levelText.SetLevel(level);
        leftText.SetLeft(left);
        ShowBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 得点処理
    void AddPoint(int addpoint)
    {
        point += addpoint;
        pointText.SetPoint(point);
    }

    void AddLevel()
    {
        if(LEVEL_MAX <= ++level){
            // ゲームクリア
            gameclear.SetActive(true);
            titleButton.SetActive(true);
            levelText.SetLevel(0);
        }
        else
        {
            // 次のレベルに進む
            levelText.SetLevel(level);
            ShowBlocks();
        }
    }

    void ShowBlocks()
    {
        leftBlock = 0;
        foreach (Transform child in blockParent[level-1].transform)
        {
            child.gameObject.SetActive(true);
            leftBlock++;
        }
    }

    // 公開インターフェイス
    public int GetLevel()
    {
        return level;
    }

    // ボールがブロックに当たった時の処理
    public void HitBlock()
    {
        AddPoint(100);
    }

    // ボールがブロックを破壊した時の処理
    public void BreakBlock()
    {
        if (0 < --leftBlock) return;

        // クリア処理
        player.EnableToShot();
        AddLevel();
        if (ball != null)
        {
            Destroy(ball);
            ball = null;
        }
    }

    public void ShootBall(Vector3 position)
    {
        // 弾を発射する場所を取得
        // "bullet"のPrefabを出現させる。Bulletの向きは正面
        ball = Instantiate(BallPrefab, position, Quaternion.identity);
        // 出現させた弾のup(Y軸方向)を取得（MuzzleのローカルY軸方向のこと）
        Vector3 direction = ball.transform.up;
        // 弾の発射方向にnewBallのY方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
        ball.GetComponent<Rigidbody>().AddForce(direction * fulletForce, ForceMode.Impulse);
    }

    public void FallBall()
    {
        Destroy(ball);
        ball = null;

        if(0 <= --left)
        {
            leftText.SetLeft(left);
            player.EnableToShot();
        }else{
            // ゲームオーバー
            gameover.SetActive(true);
            titleButton.SetActive(true);
        }
    }
}
