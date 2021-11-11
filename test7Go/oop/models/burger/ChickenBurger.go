package burger

import (
	"fmt"
)

type ChickenBurger struct {
	SimpleBurger
}

func NewChickenBurger() ChickenBurger {
	simpleBurger := NewSimpleBurger("Chicken Burger", 5.99)
	simpleBurger.Filling = fmt.Sprintf("%s,Live chicken!", simpleBurger.Filling)

	return ChickenBurger{simpleBurger}
}
