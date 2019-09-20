package application;

// класс Масло наследует интерфейс Молочный продукт
public class Butter implements MilkProduct {
    // информация о продукте
    private float weight = 3.5f;
    final private static String NAME = "Масло";

    @Override
    public float getWeight() {
        return weight;
    }

    @Override
    public String getName() {
        return NAME;
    } 
}

