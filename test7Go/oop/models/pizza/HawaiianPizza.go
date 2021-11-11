package pizza

import (
	"fmt"
)

type HawaiianPizza struct {
	SimplePizza
}

func NewHawaiianPizza() HawaiianPizza {
	simplePizza := NewSimplePizza("Hawaiien Pizza", 24.47)
	simplePizza.Topping = fmt.Sprintf("%s,pineapple,ham", simplePizza.Topping)

	return HawaiianPizza{simplePizza}
}
