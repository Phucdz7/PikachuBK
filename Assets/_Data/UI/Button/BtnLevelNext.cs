using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnLevelNext : BaseButton
{
    protected override void OnClick()
    {
        GameManager.Instance.NextLevel();
    }
}
