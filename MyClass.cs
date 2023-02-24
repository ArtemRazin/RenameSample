using System.Reflection;

namespace MyNamespace;

[ArmDot.Client.ObfuscateNames(Enable = true, Inherit = true)]
[ObfuscationAttribute(Exclude = true, ApplyToMembers = false)]
public class MyClass
{
  public int publicProperty {get; set;}
  private int privateProperty {get; set;}
  
  public double publicField;
  private double privateField;

  public void publicMethod() { }
  private void privateMethod() { }
}
