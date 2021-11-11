package drink

import (
	oop "oop/models"
)

type SimpleDrink struct {
	Incrediants string
	oop.CommandItem
}

func NewSimpleDrink(name string, price float64) SimpleDrink {
	incrediants := "water"
	commandItem := oop.CommandItem{Name: name, Price: price, Quantity: 1}

	return SimpleDrink{incrediants, commandItem}
}
