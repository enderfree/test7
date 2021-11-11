package oop

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func WaitForValidInput(nbOfChoices int) int {
	reader := bufio.NewReader(os.Stdin)

	for {
		choiceStr, e := reader.ReadString('\n')
		if e == nil {
			choice, e2 := strconv.Atoi(string(choiceStr[0]))
			if e2 == nil {
				if choice > 0 && choice <= nbOfChoices {
					return choice
				}
			}
		}

		fmt.Print("Sorry, we didn't get that, can you select the number again?")
	}
}

func WaitForInt() int {
	reader := bufio.NewReader(os.Stdin)

	for {
		choiceStr, e := reader.ReadString('\n')
		if e == nil {
			choice, e2 := strconv.Atoi(string(choiceStr[0]))
			if e2 == nil {
				return choice
			}
		}

		fmt.Print("Please answer with an integer.")
	}
}
