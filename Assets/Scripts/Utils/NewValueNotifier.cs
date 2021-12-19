using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewValueNotifier<TAwaited> : AwaiterBase<TAwaited>
{
    private readonly ScriptableObjectValueBase<TAwaited> _scriptableObjectValueBase;

    public NewValueNotifier(ScriptableObjectValueBase<TAwaited> scriptableObjectValueBase)
    {
        _scriptableObjectValueBase = scriptableObjectValueBase;
        _scriptableObjectValueBase.OnNewValue += ONNewValue;
    }

    private void ONNewValue(TAwaited obj)
    {
        _scriptableObjectValueBase.OnNewValue -= ONNewValue;
        onWaitFinish(obj);
    }
}
