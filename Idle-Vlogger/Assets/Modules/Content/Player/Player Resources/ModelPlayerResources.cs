using Modules.Content.Player.Player_Resources;
using Modules.Core.Extensions;

public class ModelPlayerResources
{
    private ReactiveProperty<int> _dollars;

    public void ChangeValueResource(TypeResources typeResources, TypeMathOperation mathOperation, int value)
    {
        switch (typeResources)
        {
            case TypeResources.Dollars:
                ApplyMathOperationOnResource(_dollars, mathOperation, value);
                break;
        }
    }

    private void ApplyMathOperationOnResource(ReactiveProperty<int> recource, TypeMathOperation mathOperation, int value)
    {
        switch (mathOperation)
        {
            case TypeMathOperation.Add:
                recource.Value += value;
                break;
            
            case TypeMathOperation.Subtract:
                recource.Value -= value;
                break;
            
            case TypeMathOperation.Change:
                recource.Value = value;
                break;
        }
    }
}