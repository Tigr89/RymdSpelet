extends Control

func _on_retrybutton_pressed():
	get_tree().reload_current_scene()

func set_score(value):
	$Panel/score.text = "score: " + str(value)

func set_highscore(value):
	$Panel/highscore.text = "highscore: " + str(value)
