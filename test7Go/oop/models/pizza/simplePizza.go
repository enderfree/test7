package pizza

import (
	oop "oop/models"
)

type SimplePizza struct {
	Topping string
	oop.CommandItem
}

func NewSimplePizza(name string, price float64) SimplePizza {
	topping := "cheese, sauce"
	commandItem := oop.CommandItem{Name: name, Price: price, Quantity: 1}

	return SimplePizza{topping, commandItem}
}
