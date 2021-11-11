package pizza

import (
	"fmt"
)

type MeatPizza struct {
	SimplePizza
}

func NewMeatPizza() MeatPizza {
	simplePizza := NewSimplePizza("Meat Pizza", 29.99)
	simplePizza.Topping = fmt.Sprintf("%s,ground beef,pepperoni", simplePizza.Topping)

	return MeatPizza{simplePizza}
}
