package donut

type PowderedDonut struct {
	SimpleDonut
}

func NewPowderedDonut() PowderedDonut {
	simpleDonut := NewSimpleDonut("Powdered Donut")
	simpleDonut.Flavor = "SUGAR!!!"

	return PowderedDonut{simpleDonut}
}
