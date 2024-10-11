extends Control

@onready var score = $score:
	set(value):
		score.text = "CURRENT SCORE: " + str(value)
