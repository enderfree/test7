package burger

import (
	"fmt"
)

type VeggyBurger struct {
	SimpleBurger
}

func NewVeggyBurger() VeggyBurger {
	simpleBurger := NewSimpleBurger("Veggy Burger", 6.99)
	simpleBurger.Filling = fmt.Sprintf("%s,Veggies", simpleBurger.Filling)

	return VeggyBurger{simpleBurger}
}
