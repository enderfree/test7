package oop

import (
	"fmt"
	models "oop/models"
	"oop/models/burger"
	"oop/models/donut"
	"oop/models/drink"
	"oop/models/pizza"
)

type Command struct {
	CommandItems []models.CommandItem
}

func SelectBurger() models.CommandItem {
	fmt.Print("\nWhich do you want to add to your command? \n" +
		"1. Veggie Burger \n" +
		"2. Healthy Burger \n" +
		"3. Chicken Burger \n" +
		"4. Ham Burger \n" +
		"5. Back to the previous menu\n")

	switch WaitForValidInput(5) {
	case 1:
		return burger.NewHealthyBurger().CommandItem
	case 2:
		return burger.NewHealthyBurger().CommandItem
	case 3:
		return burger.NewChickenBurger().CommandItem
	case 4:
		return burger.NewHamBurger().CommandItem
	case 5:
		return models.CommandItem{}
	default:
		fmt.Print("This option is not code ready!\n")
		return models.CommandItem{}
	}
}

func SelectPizza() models.CommandItem {
	fmt.Print("\nWhich do you want to add to your command? \n" +
		"1. Hawaiien Pizza \n" +
		"2. Vegetarian Pizza \n" +
		"3. Meat Pizza \n" +
		"4. Back to the previous menu\n")

	switch WaitForValidInput(4) {
	case 1:
		return pizza.NewHawaiianPizza().CommandItem
	case 2:
		return pizza.NewVegetarianPizza().CommandItem
	case 3:
		return pizza.NewMeatPizza().CommandItem
	case 4:
		return models.CommandItem{}
	default:
		fmt.Print("This option is not code ready!\n")
		return models.CommandItem{}
	}
}

func SelectDonut() models.CommandItem {
	fmt.Print("\nWhich do you want to add to your command? \n" +
		"1. Powdered \n" +
		"2. Ginger \n" +
		"3. Boston \n" +
		"4. Back to the previous menu\n")

	switch WaitForValidInput(4) {
	case 1:
		return donut.NewPowderedDonut().CommandItem
	case 2:
		return donut.NewGingerDonut().CommandItem
	case 3:
		return donut.NewBostonDonut().CommandItem
	case 4:
		return models.CommandItem{}
	default:
		fmt.Print("This option is not code ready!\n")
		return models.CommandItem{}
	}
}

func SelectDrink() models.CommandItem {
	fmt.Print("\nWhich do you want to add to your command? \n" +
		"1. Long Island Ice Tea \n" +
		"2. Sex on the Beach \n" +
		"3. Long Winded Ice Tea \n" +
		"4. Back to the previous menu\n")

	switch WaitForValidInput(4) {
	case 1:
		return drink.NewLongIslandIceTea().CommandItem
	case 2:
		return drink.NewSexOnTheBeach().CommandItem
	case 3:
		return drink.NewLongWindedIceTea().CommandItem
	case 4:
		return models.CommandItem{}
	default:
		fmt.Print("This option is not code ready!\n")
		return models.CommandItem{}
	}
}

func AddItem(c Command) Command {
	newCommandItem := models.CommandItem{}
	for (newCommandItem == models.CommandItem{}) {
		fmt.Print("\nWhich do you want to add to your command? \n" +
			"1. Burger\n" +
			"2. Pizza\n" +
			"3. Donut\n" +
			"4. Drink\n" +
			"5. Cancel\n")

		switch WaitForValidInput(5) {
		case 1:
			newCommandItem = SelectBurger()
		case 2:
			newCommandItem = SelectPizza()
		case 3:
			newCommandItem = SelectDonut()
		case 4:
			newCommandItem = SelectDrink()
		case 5:
			return c
		default:
			fmt.Print("This option is not code ready!\n")
		}
	}

	for i, item := range c.CommandItems {
		if item.Name == newCommandItem.Name {
			item.Quantity = item.Quantity + 1
			c.CommandItems[i] = item
			return c
		}
	}

	c.CommandItems = append(c.CommandItems, newCommandItem)
	return c
}

func SelectItem(c Command) int {
	if len(c.CommandItems) > 0 {
		fmt.Print("Select an Item: \n")

		for i, item := range c.CommandItems {
			fmt.Printf("%d. %s", i+1, item)
		}

		return WaitForValidInput(len(c.CommandItems)) - 1
	} else {
		fmt.Print("You need to have something in your command in order to perform this action. \n")
		return -1
	}
}

func ModifyQuantity(c Command) Command {
	id := SelectItem(c)

	if id != -1 {
		fmt.Print("What will be the new quantity?\n")
		quantity := WaitForInt()

		c.CommandItems[id].Quantity = quantity

		if c.CommandItems[id].Quantity < 1 {
			c.CommandItems[id] = c.CommandItems[len(c.CommandItems)-1]
			c.CommandItems = c.CommandItems[:len(c.CommandItems)-1]
		}
	}

	return c
}

func DeleteItem(c Command) Command {
	id := SelectItem(c)

	c.CommandItems[id] = c.CommandItems[len(c.CommandItems)-1]
	c.CommandItems = c.CommandItems[:len(c.CommandItems)-1]

	return c
}
