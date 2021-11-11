package donut

type BostonDonut struct {
	SimpleDonut
}

func NewBostonDonut() BostonDonut {
	simpleDonut := NewSimpleDonut("Boston")
	simpleDonut.Flavor = "Boston Cream"

	return BostonDonut{simpleDonut}
}
