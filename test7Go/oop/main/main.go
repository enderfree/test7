package main

import (
	"fmt"
	"oop"
	models "oop/models"
)

func main() {
	Program()
}

func DisplayCommand(c oop.Command) {
	if len(c.CommandItems) > 0 {
		var total float64 = 0

		fmt.Print("\n")
		for _, item := range c.CommandItems {
			total += item.Price * float64(item.Quantity)
			fmt.Print(item)
		}
		fmt.Printf("\nTotal: %.2f$", total)
	} else {
		fmt.Print("The command was canceled.\n")
	}
}

func ManageCommand() {
	c := oop.Command{CommandItems: []models.CommandItem{}}
	clientIsDone := false

	for !clientIsDone {
		fmt.Print("Would you like too: \n" +
			"1. Add an item to the command. \n" +
			"2. Change the quantity of something you already in the command. \n" +
			"3. Remove entirely something from the command. \n" +
			"4. I am done. \n" +
			"5. Cancel. \n")

		switch oop.WaitForValidInput(5) {
		case 1:
			c = oop.AddItem(c)
		case 2:
			c = oop.ModifyQuantity(c)
		case 3:
			c = oop.DeleteItem(c)
		case 4:
			clientIsDone = true
		case 5:
			c.CommandItems = make([]models.CommandItem, 0)
			clientIsDone = true
		default:
			fmt.Print("This option is not code ready!\n")
		}
	}

	DisplayCommand(c)
}

func Program() {
	fmt.Print("Hello and welcome to Wendies, what can I do for you?\n" +
		"1. Pass a command. \n" +
		"2. Exit.\n")

	switch oop.WaitForValidInput(2) {
	case 1:
		ManageCommand()
	case 2:
		fmt.Print("See you next time then!\n")
	default:
		fmt.Print("This option is not code ready!\n")
	}
}
