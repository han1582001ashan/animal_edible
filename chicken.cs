public class Chicken: Animal, Edible{
    public override string MakeSound()
    {
        return "chick-chick";
    }
    public string HowToEat(){
        return "coulbe pecking";
    }
}