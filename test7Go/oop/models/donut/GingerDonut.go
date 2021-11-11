package donut

type GingerDonut struct {
	SimpleDonut
}

func NewGingerDonut() GingerDonut {
	simpleDonut := NewSimpleDonut("Ron")
	simpleDonut.Flavor = "Red hairs"

	return GingerDonut{simpleDonut}
}
