using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{
    public class ManagerInitializeMono : MonoBehaviour
    {
        [SerializeField] private AbstractScriptableManagerBase[] _abstractScriptableManagerArray;
        private List<AbstractScriptableManagerBase> _InstantiatedAbstractScriptableManagerList;

        private void Start()
        {
            _InstantiatedAbstractScriptableManagerList = new List<AbstractScriptableManagerBase>
                (_abstractScriptableManagerArray.Length);
            for (int i = 0; i < _abstractScriptableManagerArray.Length; i++)
            {
                var instantiated =Instantiate(_abstractScriptableManagerArray[i]);
                instantiated.Initialize();
                _InstantiatedAbstractScriptableManagerList.Add(instantiated);
            }
        }

        private void OnDestroy()
        {
            if (_InstantiatedAbstractScriptableManagerList != null) 
            {
                for (int i = 0; i < _InstantiatedAbstractScriptableManagerList.Count; i++)
                {
                    _InstantiatedAbstractScriptableManagerList[i].Destroy();
                }
            }
        }
    }
}
