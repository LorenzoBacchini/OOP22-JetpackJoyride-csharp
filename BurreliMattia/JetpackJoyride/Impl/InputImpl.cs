using BurreliMattia.JetpackJoyride.Api;

namespace BurreliMattia.JetpackJoyride.Impl;

public class InputImpl : IInput 
{
    private readonly IInput.TypeInput _type;
    private readonly string _name;

    public IInput.TypeInput Type
    {
        get => _type;
    }

    public string Name
    {
        get => _name;
    }
    
    public InputImpl(IInput.TypeInput type, string name)
    {
        _type = type;
        _name = name;
    }
}