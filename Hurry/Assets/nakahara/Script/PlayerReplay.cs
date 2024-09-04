using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReplay : MonoBehaviour
{
    [SerializeField]
    [Tooltip("プレイヤーのプレハブを設定")]
    private GameObject playerPrefab;

    // Update is called once per frame
    void Update()
    {
        // 設定したplayerPrefabと同じ名前(今回は"PlayerSphere")のGameObjectを探して取得
        GameObject playerObj = GameObject.Find(playerPrefab.name);

        // playerObjが存在していない場合
        if (playerObj == null)
        {
            // playerPrefabから新しくGameObjectを作成
            GameObject newPlayerObj = Instantiate(playerPrefab);

            // 新しく作成したGameObjectの名前を再設定(今回は"Player"となる)
            newPlayerObj.name = playerPrefab.name;
        }
    }
}
