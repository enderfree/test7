package drink

type LongWindedIceTea struct {
	SimpleDrink
}

func NewLongWindedIceTea() LongWindedIceTea {
	simpleDrink := NewSimpleDrink("Long Winded Ice Tea", 17.47)
	simpleDrink.Incrediants = "Ice Tea, Rhum"

	return LongWindedIceTea{simpleDrink}
}
