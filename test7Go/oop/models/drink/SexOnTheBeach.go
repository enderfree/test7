package drink

type SexOnTheBeach struct {
	SimpleDrink
}

func NewSexOnTheBeach() SexOnTheBeach {
	simpleDrink := NewSimpleDrink("Sex on the Beach", 24.99)
	simpleDrink.Incrediants = "Vodka, Rhum, Limonchello, Curaçao"

	return SexOnTheBeach{simpleDrink}
}
