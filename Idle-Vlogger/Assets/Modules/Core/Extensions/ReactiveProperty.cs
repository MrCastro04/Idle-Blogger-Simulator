using System;

public class ReactiveProperty<T>
{
    private T _value;
    public Action<T> OnValueChanged;

    public T Value
    {
        get { return _value; }
        set
        {
            _value = value;
            OnValueChanged?.Invoke(_value);
        }
    }
}