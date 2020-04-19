using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDmg : Damageable_Target
{
    // Start is called before the first frame update
    public int phase = 3;

    // Update is called once per frame
    void Update()
    {
        if (health % 50 == 0) {
            phase -= 1;
        }
    }
}
