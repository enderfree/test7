package burger

import (
	oop "oop/models"
)

type SimpleBurger struct {
	Filling string
	oop.CommandItem
}

func NewSimpleBurger(name string, price float64) SimpleBurger {
	filling := "bread, sauce, tomato, onion"
	commandItem := oop.CommandItem{Name: name, Price: price, Quantity: 1}

	return SimpleBurger{filling, commandItem}
}
