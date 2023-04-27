using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeBehavior : EntityBehaviour
{

    [SerializeField]
    private float _duration = .08f;

    private Enemy _enemy;

    private Hitbox _hitboxPrefab;
    private Hitbox _localHitbox;

    protected override void DoOnDestroy()
    {
        base.DoOnDestroy();
        Destroy(_localHitbox.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartTimer(_duration);
    }
    // Update is called once per frame
    void Update()
    {
        if (TimerFinished())
        {
            _hitboxPrefab = _enemy.EnemyMelee;
            _localHitbox = Instantiate(_hitboxPrefab, transform, false);
            
        }
    }
}
