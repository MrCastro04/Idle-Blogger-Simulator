using Modules.Content.Player.Player_Resources;
using Modules.Core.Extensions;

public class ModelPlayerResources
{
    public ReactiveProperty<int> Dollars;

    public ModelPlayerResources()
    {
        Dollars = new();
    }

    public void ChangeValueResource(TypeResources typeResources, TypeMathOperation mathOperation, int value)
    {
        switch (typeResources)
        {
            case TypeResources.Dollars:
                ApplyMathOperationOnResource(Dollars, mathOperation, value);
                break;
        }
    }

    private void ApplyMathOperationOnResource(ReactiveProperty<int> recource, TypeMathOperation mathOperation,
        int value)
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