using System.Reflection;

[assembly:ArmDot.Client.ObfuscateNames]

namespace MyNamespace;

[ArmDot.Client.ObfuscateNames(Enable = false, Inherit = false)]
public class MyClass
{
  public int publicProperty {get; set;}
  private int privateProperty {get; set;}
  
  public double publicField;
  private double privateField;

  public void publicMethod() { }
  private void privateMethod() { }
}
