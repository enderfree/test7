package donut

import (
	oop "oop/models"
)

type SimpleDonut struct {
	Flavor string
	oop.CommandItem
}

func NewSimpleDonut(name string) SimpleDonut {
	flavor := "plain"
	commandItem := oop.CommandItem{Name: name, Price: 0.75, Quantity: 1}

	return SimpleDonut{flavor, commandItem}
}
