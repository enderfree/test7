package burger

import "fmt"

type HealtyBurger struct {
	SimpleBurger
}

func NewHealthyBurger() HealtyBurger {
	simpleBurger := NewSimpleBurger("Healthy Burger", 7.99)
	simpleBurger.Filling = fmt.Sprintf("%s,Healthy stuff", simpleBurger.Filling)

	return HealtyBurger{simpleBurger}
}
