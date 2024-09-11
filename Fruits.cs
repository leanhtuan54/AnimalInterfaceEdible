namespace Fruits {
  public abstract class Fruit : Edibles.Edible {
    public abstract string HowToEat();
  }

  public class Apple : Fruit {
    public override string HowToEat() {
      return "Apple could be sliced";
    }
  }

  public class Orange : Fruit {
    public override string HowToEat() {
      return "Orange could be juiced";
    }
  }
}
