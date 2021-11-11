package burger

import (
	"fmt"
)

type HamBurger struct {
	SimpleBurger
}

func NewHamBurger() HamBurger {
	simpleBurger := NewSimpleBurger("Ham Burger", 3.99)
	simpleBurger.Filling = fmt.Sprintf("%s,NotHam!", simpleBurger.Filling)

	return HamBurger{simpleBurger}
}
