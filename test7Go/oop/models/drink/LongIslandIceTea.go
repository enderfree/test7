package drink

type LongIslandIceTea struct {
	SimpleDrink
}

func NewLongIslandIceTea() LongIslandIceTea {
	simpleDrink := NewSimpleDrink("Long Island Ice Tea", 19.47)
	simpleDrink.Incrediants = "Ice Tea, Vodka, Rhum, Pineapple Juice, Peach Juice, Cayen"

	return LongIslandIceTea{simpleDrink}
}
