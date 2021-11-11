package pizza

import (
	"fmt"
)

type VegetarianPizza struct {
	SimplePizza
}

func NewVegetarianPizza() VegetarianPizza {
	simplePizza := NewSimplePizza("Vegetarian Pizza", 25.47)
	simplePizza.Topping = fmt.Sprintf("%s,tomato,mushroom", simplePizza.Topping)

	return VegetarianPizza{simplePizza}
}
