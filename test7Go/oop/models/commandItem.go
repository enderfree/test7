package oop

import (
	"fmt"
)

type CommandItem struct {
	Name     string
	Price    float64
	Quantity int
}

func (ci CommandItem) String() string {
	return fmt.Sprintf("%d %s %.2f$\n", ci.Quantity, ci.Name, ci.Price*float64(ci.Quantity))
}
